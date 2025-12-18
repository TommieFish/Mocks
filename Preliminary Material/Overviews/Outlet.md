# Outlet.md

## Overview
The `Outlet` class represents a restaurant or food outlet in a 2D space. It tracks its location, capacity, daily costs, and the number of visits per day. The class provides methods to manage capacity, calculate profit/loss, and reset daily statistics.  

**Key attributes:**
- `xCoord`, `yCoord` – coordinates of the outlet in the 2D space.  
- `capacity` – current number of meals the outlet can serve in a day.  
- `maxCapacity` – maximum possible capacity, including some randomness.  
- `visitsToday` – number of customers served today.  
- `dailyCosts` – fixed and variable daily costs associated with running the outlet.  

---

## Constructor: `Outlet(int xCoord, int yCoord, int maxCapacityBase)`
Initializes a new `Outlet` at the given coordinates.  
- Sets the initial `capacity` as 60% of `maxCapacityBase`.  
- Randomizes `maxCapacity` slightly around `maxCapacityBase`.  
- Calculates `dailyCosts` based on `capacity` and `maxCapacityBase`.  
- Resets daily statistics using `NewDay()`.

---

## Function: `GetCapacity()`
Returns the current capacity of the outlet (number of meals it can serve).

---

## Function: `GetX()`
Returns the X-coordinate of the outlet.

---

## Function: `GetY()`
Returns the Y-coordinate of the outlet.

---

## Function: `AlterDailyCost(double amount)`
Adjusts the daily costs by adding `amount`. Useful for applying additional expenses or cost reductions.

---

## Function: `AlterCapacity(int change)`
Changes the outlet’s current capacity by `change`.  
- Ensures capacity does not exceed `maxCapacity` or drop below 0.  
- Updates `dailyCosts` to reflect new capacity.  
- Returns the actual change applied to capacity.

---

## Function: `IncrementVisits()`
Increments the count of `visitsToday` by 1, used to track customer visits.

---

## Function: `NewDay()`
Resets `visitsToday` to 0, marking the start of a new day.

---

## Function: `CalculateDailyProfitLoss(double avgCostPerMeal, double avgPricePerMeal)`
Calculates the daily profit or loss based on:  
- Number of visits today (`visitsToday`)  
- Average cost per meal (`avgCostPerMeal`)  
- Average price per meal (`avgPricePerMeal`)  
- Daily fixed costs (`dailyCosts`)  
Returns a positive value for profit and negative for loss.

---

## Function: `GetDetails()`
Returns a formatted string summarizing the outlet's details, including coordinates, current capacity, maximum capacity, daily costs, and number of visits today.
