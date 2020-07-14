# Bugsy
The idea of this app is to start fairly simple. Users will be able to create an account, and log bugs. 
This idea stems from a simple bug manager I made for my team, except it will not use Active Directory to automatically grab users on our team. This will be more general purpose. This application will be more complicanted in a sense, with a full API, Database, and a frontend for both the web and desktop. (Desktop version will probably be for management of bugs.)

Bug models will start out pretty simple with a Title, Description, Tool Name, Creation Date, Status, and Version Number with relations to the User.
Future Build: There will be iterations and a Kanban style board for bug management.

### Stage 1: Backend
- [x] Wire-up simple API
- [x] Start forming API Architecture
- [x] Seed Database with dummy data
- [ ] Setup Generic Repository
- [ ] Implement API Error Handling
- [ ] Implement addition API features (i.e. - Pagination, Filtering and Sorting)

### Stage 2: Frontend
- [ ] Figure out which frontend framwork works best to get the job done

### Stage 3: Desktop UI
- [ ] Figure out which Desktop framework I want to go with (WPF, Universal, Electron, etc.)


---

## Backend
ASP.NET Core Web API will function as the backend

## Database
SQLite will be the development database, and probably Microsoft SQL Server will be production (or Azure?)

## Frontend
Debating on what would be the best framework to use on the Front-end and how I want to design it.
- Thinking a drag-and-drop style Kanban board might be fun for bug states.
