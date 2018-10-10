let value : HTMLInputElement = <HTMLInputElement>document.getElementById("valueInput");
var ConvertedValue: number;

let buttonConvertToGram:HTMLButtonElement = <HTMLButtonElement> document.getElementById("buttonConvertToGram");
let buttonConvertToOunces:HTMLButtonElement = <HTMLButtonElement> document.getElementById("buttonConvertToOunces");

function toGram(ounceValue: number){
    return ounceValue * 28.34952;
}

function toOunces(gramValue: number): number{
    return gramValue * 0.03527396195; 
}

let element1: HTMLDivElement = <HTMLDivElement> document.getElementById("convertedValue");

buttonConvertToGram.addEventListener("click", MouseEvent => {
    ConvertedValue = toGram(value.valueAsNumber);
    element1.innerHTML = ConvertedValue + " gram";
})

buttonConvertToOunces.addEventListener("click", MouseEvent => {
    ConvertedValue = toOunces(value.valueAsNumber);
    element1.innerHTML = ConvertedValue + " ounces";
})
