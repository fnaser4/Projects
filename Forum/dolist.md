# TODO List for Real-Time Forum Project

## In-Progress
- [ ] Change status to offline if there is no session
    - in user.go or user handler, not sure how to approach this honestly..
- [ ] Work on the messages database idea
    - figure out a way to make the database affective somehow 


## Done
    - [X] Fix the Logout function  

## 1. General Setup
    - [ ] Review and finalize project scope and architecture
    - [ ] Set up project repository and development environment

## 2. Private Messages

### 2.1 WebSocket Implementation
- [X] Set up WebSocket server
  - [X] Configure WebSocket server to handle connections
  - [ ] Implement connection management (connect, disconnect)
- [ ] Handle message flow
  - [X] Implement message broadcasting
  - [ ] Handle incoming and outgoing messages
- [ ] Manage user presence
  - [ ] Track online/offline status
    - [ ] Change to online when user logs in 
    - [ ] Change to offline when user 
  - [ ] Update user status in real-time

### 2.2 Frontend Integration
- [X] Create chat interface
  - [X] Design HTML structure for chat
  - [ ] Style chat interface with CSS
- [ ] Implement JavaScript for WebSocket communication
  - [ ] Connect to WebSocket server
  - [ ] Handle sending and receiving messages
- [ ] Update chat UI with real-time messages
  - [ ] Display incoming messages
  - [ ] Update chat window with new messages

### 2.3 Message Retrieval
- [ ] Implement historical message retrieval
  - [ ] Fetch past messages from the server
  - [ ] Display retrieved messages in the chat
- [ ] Handle message scrolling
  - [ ] Implement scrolling behavior to load more messages
  - [ ] Apply throttle/debounce to manage load

### 2.4 Testing
- [ ] Test WebSocket messaging functionality
  - [ ] Verify real-time message updates
  - [ ] Ensure messages are delivered correctly
- [ ] Address any issues or bugs
  - [ ] Debug message delivery issues
  - [ ] Fix UI/UX problems related to messaging

## 3. Single Page Application (SPA)

### 3.1 Dynamic Content Management
- [ ] Implement JavaScript for dynamic content
  - [ ] Manage page content updates without reloads
  - [ ] Handle view transitions (posts feed, individual posts, chat)
- [ ] Develop views
  - [ ] Create view for posts feed
  - [ ] Design view for individual posts
  - [ ] Implement chat view

### 3.2 Frontend State Management
- [ ] Manage application state
  - [X] Track user sessions
  - [X] Manage posts and comments
  - [ ] Handle chat state
- [ ] Ensure consistency
  - [ ] Synchronize state across different views
  - [ ] Maintain state during navigation

### 3.3 Navigation and UX
- [ ] Implement navigation
  - [ ] Create navigation components for different views
  - [ ] Ensure smooth transitions between views
- [ ] Refine user experience
  - [ ] Improve responsiveness and accessibility
  - [ ] Optimize user interactions and feedback

## 4. Styling (CSS)
- [X] Apply basic styling
  - [ ] Design layout, colors, and typography
  - [ ] Ensure responsive design
- [ ] Refine styling
  - [ ] Update design based on feedback
  - [ ] Add animations or effects for enhanced UX

## 5. Integration and Testing

### 5.1 Integration
- [ ] Integrate frontend with backend
  - [ ] Connect frontend components to backend APIs
  - [ ] Ensure WebSocket communication works with frontend

### 5.2 Testing
- [ ] Conduct end-to-end testing
  - [ ] Verify complete application flow
  - [ ] Ensure real-time features work as expected
- [ ] Address issues found during testing
  - [ ] Fix bugs and performance issues
  - [ ] Refine features based on testing results

