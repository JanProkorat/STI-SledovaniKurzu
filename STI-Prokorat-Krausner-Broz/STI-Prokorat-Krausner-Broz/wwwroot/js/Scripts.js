function randomColor() {
    const randNum = Math.floor(Math.random() * 16777216); //from 0 to ffffff
    return '#' + randNum.toString(16).padStart(6,"0");
}

function createGraph(bankName, type, canvasName, names, dates, data){
    let labels = [];
    var dateFormat = 'DD/MM/YYYY'; 
    for(var i in dates){
        var splitedData = dates[i].split(' ');
        labels.push(moment(splitedData[0], dateFormat));
    }
    var ctx = document.getElementById(canvasName).getContext('2d');
    var config = {
        type: 'line',
        data:{
            labels: labels
        },
        options: {
            title: {
                display: true,
                text: bankName+': Cena za '+type+' měn'
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
    };
    var chart = new Chart(ctx, config);
    for(let i = 0; i < names.length; i++){
        console.log(data[i]);
        chart.data.datasets.push({
            data: data[i],
            label: names[i],
            borderColor: randomColor(),
            fill: false
        });
    }
    chart.update();
    window.myline = chart;
}

function createCurrencyGraph(canvasName, currencyName, bankNames, dates, currenciesSales) {
    let labels = [];
    var dateFormat = 'DD/MM/YYYY'; 
    for(var i in dates){
        var splitedData = dates[i].split(' ');
        labels.push(moment(splitedData[0], dateFormat));
    }
    var ctx = document.getElementById(canvasName).getContext('2d');
    var config = {
        type: 'line',
        data:{
            labels: labels
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
    };
    var chart = new Chart(ctx, config);
    for(let i = 0; i < bankNames.length; i++){
        chart.data.datasets.push({
            data: currenciesSales[i],
            label: bankNames[i],
            borderColor: randomColor(),
            fill: false
        });
    }
    chart.update();
    window.myline = chart;
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
        datasets: [{ 
            data: dataArray,
            label: bankName,
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
                //type: 'time',
                //unit: 'day',
                //unitStepSize: 1,
                //distribution: 'series',
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
        datasets: [{ 
            data: dataArray,
            label: bankName,
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
                //type: 'time',
                //unit: 'day',
                //unitStepSize: 1,
                //distribution: 'series',
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