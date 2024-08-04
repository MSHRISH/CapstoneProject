# Use the official Python image from the Docker Hub
FROM python:3.11-slim

# Set the working directory inside the container
WORKDIR /app

# Copy the script and any other necessary files into the container
COPY bookingchecker.py .

# Install required Python packages
RUN pip install requests

# Define the command to run the script
CMD ["python", "bookingchecker.py"]
