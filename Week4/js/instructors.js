var instructorData = '{"instructorData":[{"firstName":"Marcos", "middleI":"D", "lastName":"Monroig"}, {"firstName":"Myrta", "middleI":"S", "lastName":"Merten"}, {"firstName":"Marco", "middleI":"I", "lastName":"Lovell"}, {"firstName":"Janiece", "middleI":"A", "lastName":"Kroeker"}, {"firstName":"Hilario", "middleI":"M", "lastName":"Rose"}]}'

function getData() {
    return JSON.parse(instructorData);
}

function displayProducts(instructorData) {
    var tableList = "";
    for (i = 0; i < instructorData.length; i++) {
        var firstName = instructorData[i].firstName;
        var middleI = instructorData[i].middleI;
        var lastName = instructorData[i].lastName;
        tableList += "<tr><td>" + firstName + "</td><td>" + middleI + "</td><td>" + lastName + "</td></tr>";

        document.getElementById("instructor_data").innerHTML = tableList;
    }
}

function populateTable() {
    var data = getData();
    displayProducts(data.instructorData);
}

