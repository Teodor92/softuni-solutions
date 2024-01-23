function solve(arrayOfEmployees) {
    'use strict';

    const employeeData = arrayOfEmployees.map((employeeRaw) => {
        return {
            name: employeeRaw,
            personalNumber: employeeRaw.length
        }
    })

    // const employeeData = []

    // for (const employeeRaw of arrayOfEmployees) {
    //     employeeData.push({
    //         name: employeeRaw,
    //         personalNumber: employeeRaw.length
    //     })
    // }

    employeeData.forEach((employee) => console.log(`Name: ${employee.name} -- Personal Number: ${employee.personalNumber}`))
}

solve([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ])
