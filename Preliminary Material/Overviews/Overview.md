# FoodCS Simulation – Overview

## Overview
This project simulates how food companies operate within a settlement of households.
Each day, households may choose to eat out, companies compete for customers, and financial
results are calculated.

The simulation is menu-driven and runs until the user quits.

---

## Main Components
- **Household** – Represents people who may eat out
- **Settlement / LargeSettlement** – Manages households and settlement size
- **Outlet** – Individual food outlets
- **Company** – Businesses owning outlets
- **Simulation** – Controls the program flow and daily logic

---

## How the Simulation Works
1. A settlement is created (normal or large)
2. Companies are created (default or user-defined)
3. Each day:
   - Households decide whether to eat out
   - Visits are assigned to companies based on reputation
   - Outlets calculate profit/loss
   - Random events may occur
4. The user can:
   - View households and companies
   - Modify companies
   - Advance to the next day

---

## How to Run
- Run the program
- Follow the on-screen menu
- Enter `6` to advance days
- Enter `Q` to quit
