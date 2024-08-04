import requests
import time
import json
from datetime import datetime, timedelta, timezone

# Constants
USEREMAIL = 'Shrish@gmail.com'
PASSWORD = 'string'
TOKEN_URL = 'https://moviebooking-cfg8aqccdqawdmbx.westus2-01.azurewebsites.net/api/Access/AdminLogin'
UNPAID_BOOKINGS_URL = 'https://moviebooking-cfg8aqccdqawdmbx.westus2-01.azurewebsites.net/api/Booking/GetAllUnpaidBookings'
DELETE_BOOKING_URL = 'https://moviebooking-cfg8aqccdqawdmbx.westus2-01.azurewebsites.net/api/Booking/DeleteBooking'

def get_token(username, password):
    headers={'Content-Type': 'application/json','accept':'text/plain'}
    payload = json.dumps({        
            'email': username,
            'password': password
    })
    response = requests.post(TOKEN_URL, data=payload,headers=headers)
    try:
        response.raise_for_status()
    except requests.exceptions.HTTPError as e:
        print(f"HTTP error occurred: {e}")
        print(f"Response content: {response.content}")
        return None
    return response.json()['token']

def get_unpaid_bookings(token):
    headers = {'Authorization': f'Bearer {token}', 'Content-Type': 'application/json',}
    response = requests.get(UNPAID_BOOKINGS_URL, headers=headers)
    response.raise_for_status()
    return response.json()

def delete_booking(token, booking_id):
    headers = {'Authorization': f'Bearer {token}', 'Content-Type': 'application/json',}
    response = requests.delete(f"{DELETE_BOOKING_URL}?bookingId={booking_id}", headers=headers)
    response.raise_for_status()
    return response.json()

def main():
    while True:
        try:
            token = get_token(USEREMAIL, PASSWORD)
            unpaid_bookings = get_unpaid_bookings(token)
            
            for booking in unpaid_bookings:
                 booking_time_str = booking['bookedOn']
                 booking_time = datetime.fromisoformat(booking_time_str)
                 current_utc_time = datetime.now(timezone.utc)
                 if booking_time.tzinfo is None:
                     booking_time = booking_time.replace(tzinfo=timezone.utc)
                 if current_utc_time - booking_time > timedelta(minutes=3):
                    delete_booking(token, booking['bookingId'])
                    print(f"Deleted booking ID: {booking['bookingId']} (Booked at: {booking_time_str})")
                 else:
                    print(f"Booking ID: {booking['bookingId']} is not older than 3 minutes (Booked at: {booking_time_str})")
            
            print("Completed one cycle. Sleeping for 60 seconds.")
            time.sleep(60)
        except Exception as e:
            print(f"An error occurred: {e}")
            time.sleep(60)

if __name__ == "__main__":
    main()
