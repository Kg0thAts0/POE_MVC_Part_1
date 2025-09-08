# Contract Monthly Claims System (MVC Prototype)

## Overview
This project is a prototype Contract Monthly Claims System built with ASP.NET Core MVC.  
It demonstrates the flow of a simple role-based system where different types of users can register, log in, and navigate to their role-specific dashboards.  

Note: This version is non-functional — it does not use a database.  
All pages simulate user interaction using ViewBag and simple redirects.


## Features
-Home Page: Welcome screen with navigation to Login/Register.  
-Registration: Users (Lecturers, PCs, PMs) can "register" (no data is stored).  
-Login: Users log in by entering credentials and selecting their role.  
-Role Dashboards:  
  -Lecturer Dashboard → Submit/View Claims.  
  -Program Coordinator Dashboard (PC) → Review/Approve Claims.  
  -Program Manager Dashboard (PM) → View Reports.  
-Claims Pages: Simulated submission and detail view for lecturer claims.  
-Reports Page: Displays a static placeholder for PM reports.  
-Logout Page: Confirms logout and links back to login.  
-Navigation Bar: Styled links available across all pages.  


## Technologies
-ASP.NET Core MVC
-C#
-Razor View
-HTML
-CSS

## User Flow
1. Open the Home page → Click Login or Register.  
2. If registering, enter details (Full Name, Email, Username, Password, Role).  
   - Redirects to Login.  
3. Login with a Username, Password, and Role selection.  
4. Redirects to the corresponding Dashboard.  
5. From the dashboard, users can:  
   - Lecturers → Manage Claims  
   - PCs → Review Claims  
   - PMs → View Reports  
6. Logout → Returns to Login page.


## Author
- Developed as part of a Contract Monthly Claims System project.  
