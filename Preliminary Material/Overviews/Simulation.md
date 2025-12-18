# Simulation.md

## Overview
The `Simulation` class represents a full simulation of a settlement with households and multiple companies operating food outlets.  
It manages daily operations, random events, and interactions between households and companies.  

**Key attributes:**
- `simulationSettlement` – a `Settlement` or `LargeSettlement` containing households.  
- `companies` – list of `Company` objects in the simulation.  
- `fuelCostPerUnit`, `baseCostForDelivery` – costs affecting companies’ deliveries.  
- `noOfCompanies` – number of companies in the simulation.  

---

## Constructor: `Simulation()`
Initializes the simulation:  
- Prompts the user to choose a large or normal settlement.  
- Sets settlement size and number of households.  
- Prompts the user to choose default companies or add custom starting companies.  
- Creates companies and their initial outlets.

---

## Function: `DisplayMenu()`
Displays the main menu of the simulation with options for:  
- Displaying households  
- Displaying companies  
- Modifying companies  
- Adding new companies  
- Advancing the simulation by one day  
- Quitting

---

## Function: `DisplayCompaniesAtDayEnd()`
Displays details of all companies and processes the end-of-day results for each company, including profit/loss and daily statistics.

---

## Function: `ProcessAddHouseholdsEvent()`
Randomly adds 1–4 new households to the settlement and displays a message about the new additions.

---

## Function: `ProcessCostOfFuelChangeEvent()`
Randomly increases or decreases the fuel cost per unit for a randomly chosen company and displays a message describing the change.

---

## Function: `ProcessReputationChangeEvent()`
Randomly increases or decreases the reputation of a randomly chosen company and displays a message describing the change.

---

## Function: `ProcessCostChangeEvent()`
Randomly changes either the daily costs or the average cost per meal of a randomly chosen company and displays a message describing the change.

---

## Function: `DisplayEventsAtDayEnd()`
Determines whether events occur at the end of the day (with a 25% chance) and calls the appropriate event-processing functions.

---

## Function: `ProcessDayEnd()`
Simulates a full day in the settlement:  
- Resets daily statistics for all companies  
- Determines which households eat out  
- Assigns each eating household to an outlet based on company reputation  
- Displays end-of-day company details and events

---

## Function: `AddCompany()`
Prompts the user to input information for a new company:  
- Name, starting balance, type (fast food, family, named chef)  
- Randomly selects initial outlet location  
- Adds the new company to the simulation

---

## Function: `GetIndexOfCompany(string companyName)`
Returns the index of the company with the given name.  
Returns `-1` if the company does not exist.

---

## Function: `ModifyCompany(int index)`
Allows the user to modify a company:  
- Open a new outlet  
- Close an existing outlet  
- Expand an existing outlet  
- Validates input and updates the company accordingly

---

## Function: `DisplayCompanies()`
Displays details of all companies in the simulation using each company’s `GetDetails()` method.

---

## Function: `Run()`
Runs the main simulation loop:  
- Continuously displays the menu and processes user input  
- Calls appropriate functions for each menu option  
- Exits when the user selects `Q`  
- Handles user input validation for company selection
