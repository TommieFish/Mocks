# Settlement.md

## Overview
The `Settlement` class represents a collection of households within a defined 2D area. It manages the creation, storage, and retrieval of households, as well as providing methods to interact with them, such as finding out if a household eats out.  

**Key attributes:**
- `startNoOfHouseholds` – the number of households to create initially.  
- `xSize`, `ySize` – the dimensions of the settlement area.  
- `households` – a list storing all `Household` instances in the settlement.  

---

## Constructor: `Settlement()`
Initializes a new settlement with default size (`1000 x 1000`) and a starting number of households (`250`). It automatically calls `CreateHouseholds()` to populate the settlement.

---

## Function: `GetNumberOfHouseholds()`
Returns the current number of households in the settlement.

---

## Function: `GetXSize()`
Returns the X-dimension (width) of the settlement.

---

## Function: `GetYSize()`
Returns the Y-dimension (height) of the settlement.

---

## Function: `GetRandomLocation(ref int x, ref int y)`
Generates a random location within the settlement's boundaries.  
- `x` and `y` are updated via reference to hold the random coordinates.

---

## Function: `CreateHouseholds()`
Creates the initial number of households defined by `startNoOfHouseholds`. Calls `AddHousehold()` repeatedly to populate the settlement.

---

## Function: `AddHousehold()`
Adds a single new household at a random location within the settlement. Uses `GetRandomLocation()` to determine coordinates.

---

## Function: `DisplayHouseholds()`
Prints details of all households to the console, including their ID, coordinates, and probability of eating out. Useful for debugging or visual inspection.

---

## Function: `FindOutIfHouseholdEatsOut(int householdNo, ref int x, ref int y)`
Determines if a specific household eats out on a given day.  
- `householdNo` – the index of the household in the `households` list.  
- `x` and `y` – updated via reference to hold the household's coordinates.  
- Returns `true` if the household eats out based on its probability; otherwise returns `false`.  
- Handles out-of-range indices to prevent crashes.
