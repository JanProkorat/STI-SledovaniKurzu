﻿function randomColor() {
	const randNum = Math.floor(Math.random() * 16777216); //from 0 to ffffff
	return '#' + randNum.toString(16).padStart(6, "0");
}

function openNav() {
	document.getElementById("mySidenav").style.width = "250px";
}

function closeNav() {
	document.getElementById("mySidenav").style.width = "0";
}

function createCurrencySaleGraph(canvasName, currencyName, bankNames, dates, dataArray) {
	/*let labels = [];
	for (var i in dates) {
		labels.push(new Date(dates[i]));
	}*/
	new Chart(document.getElementById(canvasName), {
		type: 'line',
		data: {
			labels: dates,
			datasets: [
				{
					data: dataArray[0],
					label: bankNames[0],
					borderColor: randomColor(),
					fill: false,
				}, {
					data: dataArray[1],
					label: bankNames[1],
					borderColor: randomColor(),
					fill: false,
				}, {
					data: dataArray[2],
					label: bankNames[2],
					borderColor: randomColor(),
					fill: false,
				}, {
					data: dataArray[3],
					label: bankNames[4],
					borderColor: randomColor(),
					fill: false,
				}, {
					data: dataArray[4],
					label: bankNames[3],
					borderColor: randomColor(),
					fill: false,
				}
			]
		},
		options: {
			title: {
				display: true,
				text: currencyName + ': Cena za prodej'
			},
			scales: {
				xAxes: [{
					type: 'time',
					unit: 'day',
					unitStepSize: 1,
					distribution: 'series',
					ticks: {
						source: 'labels',
						autoSkip: true
					}
				}],
				yAxes: [{
					display: true,
					labelString: 'Hodnota kurzu'
				}]
			}
		}
	});
}


function createCurrencyPurchaseGraph(canvasName, currencyName, bankNames, dates, dataArray) {
	/*let labels = [];
    for(var i in dates){
        labels.push(new Date(dates[i]));
    }*/
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
					label: bankNames[4],
					borderColor: randomColor(),
					fill: false
				}, {
					data: dataArray[4],
					label: bankNames[3],
					borderColor: randomColor(),
					fill: false
				}
			]
		},
		options: {
			title: {
				display: true,
				text: currencyName + ': Cena za nákup'
			},
			scales: {
				xAxes: [{
					type: 'time',
					unit: 'day',
					unitStepSize: 1,
					distribution: 'series',
					ticks: {
						source: 'labels',
						autoSkip: true
					}
				}],
				yAxes: [{
					display: true,
					labelString: 'Hodnota kurzu'
				}]
			}
		}
	});
}

function showTable(divID) {
	var divs = document.getElementsByClassName("tableDiv");
	for (var i = 0; i < divs.length; i++) {
		divs[i].style.display = "none";
	}
	document.getElementById(divID).style.display = "block";
}

function exportTable() {
	var divs = document.getElementsByClassName("tableDiv");
	var elements;
	for (var i = 0; i < divs.length; i++) {
		display = divs[i].style.display;
		if (display == 'block') {
			elements = divs[i].children;
		}
	}
	var downloadLink;
	var dataType = 'application/vnd.ms-excel';
	var tableSelect = elements[2];
	var tableHTML = tableSelect.outerHTML.replace(/ /g, '%20');

	// Specify file name
	filename = elements[0].innerHTML + "-" + elements[1].innerHTML;
	filename = filename ? filename + '.xls' : 'excel_data.xls';

	// Create download link element
	downloadLink = document.createElement("a");

	document.body.appendChild(downloadLink);

	if (navigator.msSaveOrOpenBlob) {
		var blob = new Blob(['\ufeff', tableHTML], {
			type: dataType
		});
		navigator.msSaveOrOpenBlob(blob, filename);
	} else {
		// Create a link to the file
		downloadLink.href = 'data:' + dataType + ', ' + tableHTML;

		// Setting the file name
		downloadLink.download = filename;

		//triggering the function
		downloadLink.click();
	}
}

function displayRow(id) {
	var row = document.getElementById(id);
	if (row.style.display == 'none') {
		row.style.display = 'table-row';
	} else {
		row.style.display = 'none';
	}
}

function hideDiv(hideClassName, showClassName) {
	var hideDivs = document.getElementsByClassName(hideClassName);
	var showDivs = document.getElementsByClassName(showClassName);
	for (var i = 0; i < hideDivs.length; i++) {
		hideDivs[i].style.display = "none";
		showDivs[i].style.display = "block";
	}
}

function hideGraphs() {
	var rows = document.getElementsByClassName("rowCanvasDiv");
	for (var i = 0; i < rows.length; i++) {
		rows[i].style.display = "none";
	}
}

function displayGraphRow(rowId) {
	var row = document.getElementById(rowId);
	if (row.style.display == 'none') {
		row.style.display = 'block';
	} else {
		row.style.display = 'none';
	}
}
