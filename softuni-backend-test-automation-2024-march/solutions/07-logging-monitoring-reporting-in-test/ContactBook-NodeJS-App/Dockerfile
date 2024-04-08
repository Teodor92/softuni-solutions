# Use the official Node.js 14 image as base
FROM node:18

# Set the working directory in the container
WORKDIR /usr/app

# Copy package.json and package-lock.json (if available) to the working directory
COPY package.json ./

# Install dependencies
RUN npm install

# Copy the rest of the application code to the working directory
COPY . .

# Expose the port that the app runs on
EXPOSE 8080

# Command to run the application
CMD ["node", "index.js"]