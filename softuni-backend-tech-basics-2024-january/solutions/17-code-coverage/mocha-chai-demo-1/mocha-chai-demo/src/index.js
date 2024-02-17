function add(a, b) {
  return a + b;
}

function subtract(a, b) {
  return a - b;
}

function formatGrade(grade) {
  if (grade < 3) {
    return `Fail (2)`;
  }
  else if (grade >= 3 && grade < 3.5) {
    return `Poor (${grade.toFixed(2)})`;
  }
  else if (grade >= 3.5 && grade < 4.5) {
    return `Good (${grade.toFixed(2)})`;
  }
  else if (grade >= 4.5 && grade < 5.5) {
    return `Very good (${grade.toFixed(2)})`;
  }
  else if (grade >= 5.5 && grade <= 6) {
    return `Excellent (${grade.toFixed(2)})`;
  } else {
    throw new Error('Invalid grade');
  }
}

module.exports = {
  add,
  subtract,
  formatGrade,
}
