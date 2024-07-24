## Architecture
The API will be running on a separate VM within a Docker container.

The routing and rendering of web pages to the client will be managed using a 'flask' application that runs on separate VM (within a Docker container). This application will communicate with the backend api and acts kinda like middle man between client and the API.

There is another python script runnning separately in another VM that constantly monitors the database for incomplete payment bookings and deletes the bookings.

Azure is used to provision the VMs and SQL Server which contains the DB.

## API Endpoints
* Admin Side:
    * Admin Login
    * Add a movie
    * Add a theater
    * Add a screen (with layout schema)
    * Add show
    * Add snacks
    * View bookings
    * View all now showing movies
    * View all shows for a movie
    * View snacks
* Customer side:
    * Customer Signup
    * Customer Login
    * View all now showing movies
    * View all theaters for a movie
    * View all shows for a movie
    * View Screen Schema while booking
    * Select and book tickets (Allow snacks to add snacks with it)
    * Confirm payment for ticket confirmation
    * View my bookings