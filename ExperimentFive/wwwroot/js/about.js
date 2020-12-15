window.onload = function(){
    
    fetch('http://localhost:5000/GetString')
    .then(response => response.json() )
    .then(data => console.log('GetString', data));

    fetch('http://localhost:5000/AddAndReturn?number1=4&number2=6')
    .then(response => response.json() )
    .then(data => console.log('AddAndReturn', data));

    fetch('http://localhost:5000/GetBoolean')
    .then(response => response.json())
    .then(data => console.log('GetBoolean', data));
    
    fetch('http://localhost:5000/GetJsonObject')
    .then(response => response.json())
    .then(data => console.log('GetJsonObject', data));

    fetch('http://localhost:5000/GetJsonObjectVariables?color=red')
    .then(response => response.json())
    .then(data => console.log('GetJsonObjectVariables', data))

}