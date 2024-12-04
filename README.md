# Hospital Charges Calculator

A Windows Forms Application that calculates hospital charges based on the length of stay and various additional expenses. This project provides a user-friendly interface to compute base, additional, and total hospital charges.

---

## Features

- **Base Charges Calculation**:
  - Automatically calculates the charges based on the number of hospital stay days at a rate of $350 per day.
  
- **Additional Charges**:
  - Allows users to input costs for:
    - Medication
    - Surgical procedures
    - Lab tests
    - Rehabilitation services
  
- **Total Charges**:
  - Computes the total by summing base and additional charges.

- **Input Validation**:
  - Ensures all user inputs are valid numbers and non-negative values.

- **User-Friendly Controls**:
  - **Calculate**: Computes the charges.
  - **Clear**: Resets all inputs and outputs.
  - **Exit**: Closes the application.

---

## How to Use

1. **Input the Data**:
   - Enter the number of days for the hospital stay in the **Days** textbox.
   - Input the costs for medication, surgical procedures, lab tests, and rehabilitation in their respective textboxes.

2. **Calculate Charges**:
   - Click the **Calculate** button.
   - The application will validate the input, perform calculations, and display:
     - **Base Charges**
     - **Additional Charges**
     - **Total Charges**

3. **Clear Input**:
   - Use the **Clear** button to reset all fields and start a new calculation.

4. **Exit the Application**:
   - Use the **Exit** button to close the program.

---

## Example Scenario

**Input**:
- Days: 5
- Medication: $150.00
- Surgical: $2,500.00
- Lab: $300.00
- Rehabilitation: $1,000.00

**Output**:
- Base Charges: `$1,750.00`
- Additional Charges: `$3,950.00`
- Total Charges: `$5,700.00`

---

## Requirements

- **Operating System**: Windows
- **Development Environment**: Visual Studio (Windows Forms Application)
- **.NET Framework**: 4.7.2 or higher

---

## File Descriptions

- **`Form1.cs`**:
  - Handles the logic for calculating and displaying hospital charges.
  - Includes methods for validating input, calculating base charges, additional charges, and total charges.
- **`Program.cs`**:
  - Entry point for the application.

---

## Error Handling

- Validates all user inputs to ensure:
  - Inputs are numeric.
  - Inputs are non-negative.
- Displays error messages for invalid or missing inputs.

---

## Future Enhancements

- Allow dynamic configuration of daily charges.
- Add support for multiple currencies.
- Enable saving and exporting calculations to a file.

---

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute it as you see fit.

---
