import {lookupChar} from "./charLookUp.js"
import {expect} from 'chai'

describe("lookupChar", () => {

    it("should return undefined when Fisrt parameter is from incorrect and second parameter is correct type", ()=>{
        //Arrange
        const incorrectFirstParam = 123;
        const correctSecondParam = 1;
        //Act
        const undefinedResult = lookupChar(incorrectFirstParam, correctSecondParam);
        //Assert
        expect(undefinedResult).to.be.undefined;
    })

    it("should return undefined when Fisrt parameter is from correct type and second parameter is with incorrect type", ()=>{
        //Arrange
        const correctFirstParam = "some string here";
        const incorrectSecondParam = "10";
        //Act
        const undefinedResult = lookupChar(correctFirstParam, incorrectSecondParam);
        //Assert
        expect(undefinedResult).to.be.undefined;
    })

    it("should return undefined when Fisrt parameter is from correct type and second parameter is with incorrect float type", ()=>{
        //Arrange
        const correctFirstParam = "some string here";
        const incorrectFloatNumberSecondParam = 10.10;
        //Act
        const undefinedResult = lookupChar(correctFirstParam, incorrectFloatNumberSecondParam);
        //Assert
        expect(undefinedResult).to.be.undefined;
    })

    it("should return Incorrect Index when Fisrt parameter is from correct type and second parameter is bigger than the string length", ()=>{
        //Arrange
        const correctFirstParam = "some string here";
        const biggerLegthSecondParam = 20;
        //Act
        const incorrectIndexResult = lookupChar(correctFirstParam, biggerLegthSecondParam);
        //Assert
        expect(incorrectIndexResult).to.be.equal("Incorrect index");
    })

    it("should return Incorrect Index when Fisrt parameter is from correct type and second parameter is lower than the string length", ()=>{
        //Arrange
        const correctFirstParam = "some string here";
        const lowerLegthSecondParam = -20;
        //Act
        const incorrectIndexResult = lookupChar(correctFirstParam, lowerLegthSecondParam);
        //Assert
        expect(incorrectIndexResult).to.be.equal("Incorrect index");
    })

    it("should return correct when all the parameters are correct", ()=>{
        //Arrange
        const correctFirstParam = "some string here";
        const correctSecondParam = 1;
        //Act
        const correctresult = lookupChar(correctFirstParam, correctSecondParam);
        //Assert
        expect(correctresult).to.be.equal("o");
    })
})