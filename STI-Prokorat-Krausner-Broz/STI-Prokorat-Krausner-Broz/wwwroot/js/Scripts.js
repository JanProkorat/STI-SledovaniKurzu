function randomColor() {
    const randNum = Math.floor(Math.random() * 16777216); //from 0 to ffffff
    return '#' + randNum.toString(16).padStart(6,"0");
}

function openNav() {
  document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
  document.getElementById("mySidenav").style.width = "0";
}

function createCurrencySaleGraph(canvasName, currencyName, bankName, dates, dataArray) {
    let labels = [];
    var dateFormat = 'DD/MM/YYYY'; 
    for(var i in dates){
        var splitedData = dates[i].split(' ');
        labels.push(moment(splitedData[0], dateFormat));
    }
    new Chart(document.getElementById(canvasName), {
      type: 'line',
      data: {
        labels: dates,
        datasets: [
                { 
                    data: dataArray[0],
                    label: bankNames[0],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[1],
                    label: bankNames[1],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[2],
                    label: bankNames[2],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[3],
                    label: bankNames[3],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[4],
                    label: bankNames[4],
                    borderColor: randomColor(),
                    fill: false
                }
            ]
      },
      options: {
        title: {
          display: true,
          text: currencyName+': Cena za prodej'
        },
        scales:{
            xAxes: [{
                type: 'time',
                unit: 'day',
                unitStepSize: 1,
                distribution: 'series',
                ticks:{
                    source: 'labels'
                }
            }],
            yAxes:[{
                display: true,
                labelString: 'Hodnota kurzu'
            }]
        }
      }
    });
}


function createCurrencyPurchaseGraph(canvasName, currencyName, bankName, dates, dataArray) {
    let labels = [];
    var dateFormat = 'DD/MM/YYYY'; 
    for(var i in dates){
        var splitedData = dates[i].split(' ');
        labels.push(moment(splitedData[0], dateFormat));
    }
    new Chart(document.getElementById(canvasName), {
      type: 'line',
      data: {
        labels: dates,
            datasets: [
                { 
                    data: dataArray[0],
                    label: bankNames[0],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[1],
                    label: bankNames[1],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[2],
                    label: bankNames[2],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[3],
                    label: bankNames[3],
                    borderColor: randomColor(),
                    fill: false
                }, {
                    data: dataArray[4],
                    label: bankNames[4],
                    borderColor: randomColor(),
                    fill: false
                }
            ]
      },
      options: {
        title: {
          display: true,
          text: currencyName+': Cena za nákup'
        },
        scales:{
            xAxes: [{
                type: 'time',
                unit: 'day',
                unitStepSize: 1,
                distribution: 'series',
                ticks:{
                    source: 'labels'
                }
            }],
            yAxes:[{
                display: true,
                labelString: 'Hodnota kurzu'
            }]
        }
      }
    });
}

function showTable(bankName){
    var body = document.getElementsByTagName("body")[0];

    // creates a <table> element and a <tbody> element
    var tbl = document.createElement("table");
    var tblBody = document.createElement("tbody");

    // creating all cells
    for (var i = 0; i < 2; i++) {
    // creates a table row
        var row = document.createElement("tr");

        for (var j = 0; j < 2; j++) {
        // Create a <td> element and a text node, make the text
        // node the contents of the <td>, and put the <td> at
        // the end of the table row
            var cell = document.createElement("td");
            var cellText = document.createTextNode("cell in row "+i+", column "+j);
            cell.appendChild(cellText);
            row.appendChild(cell);
        }

        // add the row to the end of the table body
        tblBody.appendChild(row);
    }
  // put the <tbody> in the <table>
  tbl.appendChild(tblBody);
  // appends <table> into <body>
  body.appendChild(tbl);
  // sets the border attribute of tbl to 2;
  tbl.setAttribute("border", "2");
}

function showTable(divID){
    var divs = document.getElementsByClassName("tableDiv");
    for(var i = 0; i < divs.length; i++){
        divs[i].style.display = "none";
    }
    document.getElementById(divID).style.display = "block";
}

