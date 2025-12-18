# LargeSettlement.md

## Overview
The `LargeSettlement` class is a subclass of `Settlement` that allows creating a larger settlement area with more households. It extends the base `Settlement` by increasing the dimensions and the number of initial households, then populates the extra households automatically.  

**Key attributes (inherited from `Settlement`):**
- `xSize`, `ySize` – dimensions of the settlement, increased by `extraXSize` and `extraYSize`.  
- `startNoOfHouseholds` – the number of households, increased by `extraHouseholds`.  
- `households` – list of `Household` instances, including the extra households added.  

---

## Constructor: `LargeSettlement(int extraXSize, int extraYSize, int extraHouseholds)`
Initializes a new `LargeSettlement` by:  
1. Calling the base `Settlement` constructor to create the default settlement.  
2. Expanding the settlement dimensions by `extraXSize` and `extraYSize`.  
3. Increasing the number of households by `extraHouseholds`.  
4. Adding the extra households to the settlement using `AddHousehold()` in a loop.

**Notes:**  
- Inherits all functions and behaviors from `Settlement`, such as `GetNumberOfHouseholds()`, `DisplayHouseholds()`, and `FindOutIfHouseholdEatsOut()`.  
- Designed for scenarios where a settlement needs to be larger than the default size with more households.
