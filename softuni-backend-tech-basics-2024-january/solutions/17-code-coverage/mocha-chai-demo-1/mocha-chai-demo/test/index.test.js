const { add, subtract, formatGrade } = require('../src/index');

describe('Add function', () => {
  it('should add two numbers', () => {
    expect(add(1, 2)).toBe(3);
  });
});

describe('Subtract function', () => {
  it('should subtract two numbers', () => {
    expect(subtract(2, 1)).toBe(1);
  })
});

describe('formatGrade', () => {
  it('should show failed grade', () => {
    expect(formatGrade(2)).toBe('Fail (2)');
  });

  it('should show poor grade', () => {
    expect(formatGrade(3.3000000)).toBe('Poor (3.30)');
  });

  it('should show a good grade', () => {
    expect(formatGrade(4.40001123)).toBe('Good (4.40)');
  });

  it('should show a very good grade', () => {
    expect(formatGrade(5.499999999)).toBe('Very good (5.50)');
  });

  it('should show an excellent grade', () => {
    expect(formatGrade(6)).toBe('Excellent (6.00)');
  });

  it('should throw an error if grade is invalid', () => {
    expect(() => formatGrade(1000)).toThrow('Invalid grade');
  })
})