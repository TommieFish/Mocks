# Household.md

## Overview
The `Household` class represents a household in a 2D space, with coordinates and a probability of eating out on any given day. Each household is assigned a unique ID automatically. The class provides methods to retrieve its details, location, and eating-out probability.  

**Key attributes:**
- `chanceEatOutPerDay` – the daily probability that the household eats out, randomly generated.  
- `xCoord`, `yCoord` – the coordinates of the household in a 2D space.  
- `ID` – a unique identifier for each household.  
- `nextID` – static variable to keep track of the next ID to assign.  

---

## Constructor: `Household(int x, int y)`
Initializes a new `Household` instance with coordinates `(x, y)`, assigns it a random probability to eat out, and sets a unique ID.

---

## Function: `GetDetails()`
Returns a formatted string containing the household's ID, coordinates, and probability of eating out. Useful for displaying all key information about the household at once.

---

## Function: `GetChanceEatOut()`
Returns the household’s probability of eating out. This is a simple getter for the `chanceEatOutPerDay` attribute.

---

## Function: `GetX()`
Returns the X-coordinate of the household.

---

## Function: `GetY()`
Returns the Y-coordinate of the household.
