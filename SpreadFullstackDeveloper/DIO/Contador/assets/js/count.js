var numberHTML = document.getElementById('number')
var number = 0;

function increment(){
    number += 1;
    color()
    numberHTML.innerHTML = number;
}

function decrement(){
    number -= 1;
    color()
    numberHTML.innerHTML = number;
}

function color(){
    if(number < 0){
        numberHTML.style.color = 'red';
    }
    else if(number == 0){
        numberHTML.style.color = 'white';
    }
    else{
        numberHTML.style.color = 'blue';
    }
}