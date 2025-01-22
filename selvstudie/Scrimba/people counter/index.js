let count = 0
let saved = false
function increment(){
    var element = document.getElementById("count-el");    
    count = parseInt(element.textContent)
    element.textContent = ++count;
}

function save(){
    let doc = document.getElementById("save-el");
    if(!doc.textContent.includes(count)){
        if(saved){
            doc.textContent += ` - ${count}`
        }else{
            saved = true
            doc.textContent += `${count}`
        }
    }
}