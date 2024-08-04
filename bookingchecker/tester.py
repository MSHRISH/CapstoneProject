import requests
import time
import json

# Constants
USEREMAIL = "Shrish@gmail.com"
PASSWORD = "string"
TOKEN_URL = 'https://moviebooking-cfg8aqccdqawdmbx.westus2-01.azurewebsites.net/api/Access/AdminLogin'
UNPAID_BOOKINGS_URL = 'https://moviebooking-cfg8aqccdqawdmbx.westus2-01.azurewebsites.net/api/Booking/GetAllUnpaidBookings'


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

unpaid_bookings=get_unpaid_bookings(get_token(USEREMAIL,PASSWORD))

for i in unpaid_bookings:
    print(i['bookingId'])