trykket = 0
base = document.querySelector('h1').innerHTML
tag = document.querySelector('h1')
function skift(farge){
    tag.style.color = farge
    if (trykket == 0)
        tag.innerHTML = base;
    else
        tag.textContent = `${base} - trykket: ${trykket}`
}

function farge(){
    switch(trykket++){
        case 0:
            skift("blue")
            break;
        case 1:
            skift("red")
            break;
        case 2:
            skift("green")
            break;
        case 3:
            skift("yellow")
            break;
        case 4:
            skift("purple")
            break;
        case 5:
            skift("pink")
            break;
        case 6:
            skift("orange")
            break;
        case 7:
            skift("cyan")
            break;
        default:
            trykket = 0
            skift("black")
    }
}