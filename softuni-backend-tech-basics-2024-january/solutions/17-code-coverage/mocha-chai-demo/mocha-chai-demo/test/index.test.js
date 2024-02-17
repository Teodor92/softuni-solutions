const dynamicImportChai = async () => {
  const { expect } = await import('chai');
  return expect;
};

describe('Add function', () => {
  let add;
  let expect;

  before(async () => {
    expect = await dynamicImportChai();
    const module = await import('../src/index.js');
    add = module.add;
  });

  it('should add two numbers', () => {
    expect(add(2, 3)).to.equal(5);
  });
});

describe('Subtract function', () => {
  let subtract;
  let expect;

  before(async () => {
    expect = await dynamicImportChai();
    const module = await import('../src/index.js');
    subtract = module.subtract;
  });

  it('should add two numbers', () => {
    expect(subtract(2, 3)).to.equal(-1);
  });
});

