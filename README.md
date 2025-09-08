# Contract Monthly Claims System (MVC Prototype)

## Overview
This project is a prototype Contract Monthly Claims System built with ASP.NET Core MVC.  
It demonstrates the flow of a simple role-based system where different types of users can register, log in, and navigate to their role-specific dashboards.  

Note: This version is non-functional — it does not use a database.  
All pages simulate user interaction using ViewBag and simple redirects.


## Features
1. Home Page: Welcome screen with navigation to Login/Register.  
2. Registration: Users (Lecturers, PCs, PMs) can "register" (no data is stored).  
3. Login: Users log in by entering credentials and selecting their role.  
4. Role Dashboards:  
  -Lecturer Dashboard → Submit/View Claims.  
  -Program Coordinator Dashboard (PC) → Review/Approve Claims.  
  -Program Manager Dashboard (PM) → View Reports.  
5. Claims Pages: Simulated submission and detail view for lecturer claims.  
6. Reports Page: Displays a static placeholder for PM reports.  
7. Logout Page: Confirms logout and links back to login.  
8. Navigation Bar: Styled links available across all pages.  


## Technologies
1. ASP.NET Core MVC
2. C#
3. Razor View
4. HTML
5. CSS

## User Flow
1. Open the Home page → Click Login or Register.  
2. If registering, enter details (Full Name, Email, Username, Password, Role).  
   - Redirects to Login.  
3. Login with a Username, Password, and Role selection.  
4. Redirects to the corresponding Dashboard.  
5. From the dashboard, users can:  
   - Lecturers → Submits Claims and Track claim  
   - PCs → Review Claims and views claim history
   - PMs → Approves claims and views claim history
6. Logout → Returns to Login page.

## Notes
- This is a prototype only:  
  - No database or authentication is implemented.  
  - Registration and login do not persist data.  
- Suitable for UI demonstration and project planning.  
- Can later be extended with Entity Framework + Identity for full functionality.

## Author
- Developed by Kgothatso Magwaza  
