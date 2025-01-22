function increment(){
    var element = document.getElementById("count-el");
    var value = parseInt(element.textContent)
    element.textContent = ++value;
}