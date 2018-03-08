'use script'

myApp.controller("operationIndexController",[
	"$scope",
	"$timeout",
	"defaultInput",
	"$http",
	"operationIndexService",
	function($scope,$timeout,defaultInput,$http,operationIndexService){
	debugger;
	
	var myChart = echarts.init(document.getElementById('echarts-demo'));

	var option={
		    title: {
		        text: '全球风场',
		        subtext: '所有风场运行指标',
	        	textStyle: {
	                color: '#fff'
	           	},
		        top: 10,
		        left: 10
		    },
		    tooltip: {
		        trigger: 'item',
		        backgroundColor : 'rgba(0,0,250,0.2)'
		    },
		    legend: {
		        type: 'scroll',
		        bottom: 10,
		        textStyle: {
		                color: '#fff'
		           },
		    },
		    visualMap: {
		        top: 'middle',
		        right: 10,
		        color: ['pink', 'purple'],
		        calculable: true
		    },
		    radar: {
		       indicator : [
		    	   	{ text: '风资源',max: 10},
			          { text: '发电量',max: 10},
			          { text: '可靠性',max: 10},
			          { text: '利用率',max: 10},
			          { text: '自耗电',max: 10},
			          { text: '运维性',max: 10}
		        ]
		    },
		    series :  [
        		{
                name:'浏览器（数据纯属虚构）',
                type: 'radar',
                symbol: 'none',
                itemStyle: {
                    normal: {
                        lineStyle: {
                          width:1
                        }
                    },
                    emphasis : {
                        areaStyle: {color:'rgba(0,250,0,0.6)'}
                    }
                },
           	}
       	]
   	  }

	
	$scope.showData = function(){
		var dateBegin = new Date();
		var dateEnd = new Date();
		operationIndexService.findAll(dateBegin,dateEnd,function (response){
			debugger;
	    	// 请求成功执行代码
	    	$scope.allFarmCols ="";
			$scope.allFarmContent = "";
			myChart.clear();
			
			var data = [];
	        var legends = [];
			var dataList = new Array();
			dataList = response.data;
			var tableRows = [];
			for (var i = 0; i <dataList.length; i++) {
				var tableRow = [
				    dataList[i].farmName,
				    parseFloat(dataList[i].windResource).toFixed(2),
				    parseFloat(dataList[i].energyResource).toFixed(2),
				    parseFloat(dataList[i].reliability).toFixed(2),
				    parseFloat(dataList[i].availability).toFixed(2),
				    parseFloat(dataList[i].energyConsumption).toFixed(2),
				    parseFloat(dataList[i].ops).toFixed(2)];
				    tableRows.push(tableRow);
				    legends.push(dataList[i].windFarm);
		            data.push({
	                    value:[
	                    	parseFloat(dataList[i].windResource).toFixed(2),
			        		parseFloat(dataList[i].energyResource).toFixed(2),
			        		parseFloat(dataList[i].reliability).toFixed(2),
			        		parseFloat(dataList[i].availability).toFixed(2),
			        		parseFloat(dataList[i].energyConsumption).toFixed(2),
			        		parseFloat(dataList[i].ops).toFixed(2)
	                    ],
	                    name: dataList[i].farmName   	
		            });
				}

				option['legend'].data = legends;
				option['series'][0].data = data;
				myChart.setOption(option);
				$scope.allFarmCols = ['风场名','风资源','发电量','可靠性','利用率','自耗电','运维性'];
				$scope.allFarmContent = tableRows;			     
		})
	}

}]);	