const cities= ["new york", "london", "paris", "berlin", "copenhagen"]
let liste = document.getElementById("cityList")

cities.forEach(city => {
    const li = document.createElement("li");
    li.classList.add("city", city.replace(' ', ''))
    li.innerText = city;
    liste.appendChild(li);
});