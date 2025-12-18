# Company.md

## Overview
The `Company` class represents a business that operates one or more food outlets. It manages financials, reputation, and the operations of all its outlets. The class provides methods to open or close outlets, track visits, calculate profits and losses, and handle daily operations.  

**Key attributes:**
- `name` – the company name.  
- `category` – type of business (e.g., fast food, family, or named chef).  
- `balance` – current financial balance.  
- `reputationScore` – reputation rating between 0 and 100.  
- `avgCostPerMeal`, `avgPricePerMeal` – average meal costs and prices.  
- `dailyCosts` – ongoing daily operational costs.  
- `fuelCostPerUnit`, `baseCostOfDelivery` – used for calculating delivery expenses.  
- `outlets` – list of `Outlet` instances owned by the company.  
- `familyOutletCost`, `fastFoodOutletCost`, `namedChefOutletCost` – costs for opening outlets by type.  
- `familyFoodOutletCapacity`, `fastFoodOutletCapacity`, `namedChefOutletCapacity` – default capacities for each outlet type.  

---

## Constructor: `Company(string name, string category, double balance, int x, int y, double fuelCostPerUnit, double baseCostOfDelivery)`
Initializes a new company, sets attributes based on the category, calculates initial reputation, and opens the first outlet at coordinates `(x, y)`.

---

## Function: `GetName()`
Returns the company's name.

---

## Function: `GetNumberOfOutlets()`
Returns the number of outlets the company currently operates.

---

## Function: `GetReputationScore()`
Returns the company’s current reputation score.

---

## Function: `AlterDailyCosts(double change)`
Adjusts the company's daily costs by the given amount.

---

## Function: `AlterAvgCostPerMeal(double change)`
Adjusts the average cost per meal for all outlets.

---

## Function: `AlterFuelCostPerUnit(double change)`
Adjusts the fuel cost per unit, used in delivery cost calculations.

---

## Function: `AlterReputation(double change)`
Modifies the company’s reputation score by a specified amount. Ensures reputation stays within 0 to 100.

---

## Function: `NewDay()`
Resets daily statistics for all outlets by calling `NewDay()` on each.

---

## Function: `AddVisitToNearestOutlet(int x, int y)`
Finds the outlet closest to the given coordinates and increments its visit count. Used to simulate customers visiting the nearest outlet.

---

## Function: `GetDetails()`
Returns a formatted string with all company information: name, category, balance, average meal cost and price, daily costs, delivery costs, reputation, and details of all outlets.

---

## Function: `ProcessDayEnd()`
Calculates the company’s profit or loss for the day:  
- Computes profit/loss for each outlet  
- Adds daily costs and delivery costs  
- Updates the company balance  
- Returns a summary string of the day’s results

---

## Function: `CloseOutlet(int ID)`
Removes the outlet with the specified ID from the list of outlets.  
- Returns `true` if no outlets remain after closing, indicating the company is effectively closed.

---

## Function: `ExpandOutlet(int ID)`
Prompts the user to expand the capacity of a specified outlet. Updates the outlet's capacity and provides feedback if the maximum capacity is reached.

---

## Function: `OpenOutlet(int x, int y)`
Opens a new outlet at the given coordinates based on the company category:  
- Deducts the opening cost from the balance  
- Sets capacity according to the outlet type  
- Adds the new outlet to the `outlets` list

---

## Function: `GetListOfOutlets()`
Returns a list of integers representing the IDs (indices) of all outlets. Useful for iterating over outlets.

---

## Function: `GetDistanceBetweenTwoOutlets(int outlet1, int outlet2)`
Calculates the Euclidean distance between two outlets specified by their indices.  

---

## Function: `CalculateDeliveryCost()`
Calculates the total delivery cost to all outlets:  
- Sums distances between consecutive outlets  
- Multiplies total distance by `fuelCostPerUnit`  
- Returns the total delivery cost
