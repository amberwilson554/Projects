// JavaScript source code
let calcArray = new Array(0);
let tackValue = "";
function trackingNumbers(value)
{

    if (value == "C") {
        
        clearScreen();
    }
    else {

        if (value != "e")        //adding clicked elements to an array
        {
            calcArray.push(value);
            trackValue = trackValue + value;
            document.getElementById("inputScreen").innerHTML = trackValue;
            // console.log(value);
        }
        else {
            trackValue = "";
            calculateArray();   //calculating array when = is clicked
        }
    }
}
function calculateArray() {
    var num = "";
    var num1="";
    var sign= "";
    var total= 0;
    var number1= 0;
    var number2= 0;
   

    for (let i = 0; i < calcArray.length; ++i) {
        //console.log(typeof (calcArray[i]));

        if (calcArray[i] == "p") {
            sign = calcArray[i];
            num1 = num;
            num = "";  //resetting num string
        
        }
        else if (calcArray[i] == "m") {
            sign = calcArray[i];
            num1 = num; //putting first set of numbers in a holder
            num = "";  //resetting num string to catch 2nd pair of numbers

        }
        else if (calcArray[i] == "d") {
            sign = calcArray[i];
            num1 = num;
            num = "";  
        }
        else if (calcArray[i] == "x") {
            sign = calcArray[i];
            num1 = num;
            num = "";
        }
        else if (calcArray[i] == "C") {
            clearScreen();
        }
        else {
            //console.log(typeof calcArray[i]);
            num += calcArray[i]; //append the number to the current number
            
        }

    }

    number1 = parseInt(num1);
    number2 = parseInt(num);
   
    if (sign == "p") {
        total = number1 + number2;
        outputScreen(total);
    }
    else if (sign == "m") {
        total = number1 - number2;
        outputScreen(total);
    }
    else if (sign == "d") {
        if (number1 == 0) {
            document.getElementById("inputScreen").innerHTML = "error";
        }
        total = number1 / number2;
        outputScreen(total);
    }
    else if (sign == "x") {
        total = number1 * number2;
        outputScreen(total);
    }
    else {

    }
  
}

function outputScreen(total) {
    var totalString;
    
    totalString = total.toString();
    //console.log(typeof (totalString));
    console.log(totalString);
    document.getElementById("inputScreen").innerHTML = totalString;
}

function clearScreen() {
    document.getElementById("inputScreen").innerHTML = "0";
    while(calcArray.lengeth != 0) {
        calcArray.pop();
        calcArray.length--;

    };
}