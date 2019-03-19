function randomColor() {
    const randNum = Math.floor(Math.random() * 16777216); //from 0 to ffffff
    return '#' + randNum.toString(16).padStart(6,"0");
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