import { rgbToHexColor } from './rgb-to-hex.js'
import { expect } from 'chai'

describe('rgbToHexColor', () => {
    it('should return undefined if red value is invalid', () => {
        // Arrange
        // Act
        const nonNumericRedValueResult = rgbToHexColor('123', 0, 0)
        const negativeRedValueResult = rgbToHexColor(-123, 0, 0)
        const tooBigRedValue = rgbToHexColor(999, 0, 0)
        // Assert
        expect(nonNumericRedValueResult).to.be.undefined
        expect(negativeRedValueResult).to.be.undefined
        expect(tooBigRedValue).to.be.undefined
    })

    it('should return undefined if green value is invalid', () => {
        // Arrange
        // Act
        const nonNumericGreenValueResult = rgbToHexColor(0, '123', 0)
        const negativeGreenValueResult = rgbToHexColor(0, -123, 0)
        const tooBigGreenValue = rgbToHexColor(0, 999, 0)
        // Assert
        expect(nonNumericGreenValueResult).to.be.undefined
        expect(negativeGreenValueResult).to.be.undefined
        expect(tooBigGreenValue).to.be.undefined
    })

    it('should return undefined if blue value is invalid', () => {
                // Arrange
        // Act
        const nonNumericBlueValueResult = rgbToHexColor(0, 0, '123')
        const negativeBlueValueResult = rgbToHexColor(0, 0, -123)
        const tooBigBlueValue = rgbToHexColor(0, 0, 999)
        // Assert
        expect(nonNumericBlueValueResult).to.be.undefined
        expect(negativeBlueValueResult).to.be.undefined
        expect(tooBigBlueValue).to.be.undefined
    })

    it('should return a correct hex value if a correct rgb is given', () => {
        // Arrange
        const redValue = 223;
        const greenValue = 123;
        const blueValue = 12;
        // Act
        const result = rgbToHexColor(redValue, greenValue, blueValue);
        // Assert
        expect(result).to.equals('#DF7B0C')
    })

    it('should return a correct hex value if a max rgb value is given', () => {
        // Arrange
        const redValue = 255;
        const greenValue = 255;
        const blueValue = 255;
        // Act
        const result = rgbToHexColor(redValue, greenValue, blueValue);
        // Assert
        expect(result).to.equals('#FFFFFF')
    })

    it('should return a correct hex value if a min rgb value is given', () => {
        // Arrange
        const redValue = 0;
        const greenValue = 0;
        const blueValue = 0;
        // Act
        const result = rgbToHexColor(redValue, greenValue, blueValue);
        // Assert
        expect(result).to.be.equals('#000000')
        // expect(result).equals('#000000')
    })
})
