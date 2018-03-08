'use script'

myApp.service('operationIndexService',[
	"$http",
	"ApiUrl",
	function ($http,ApiUrl) {  
		return{
			findAll:function (dateBegin,dateEnd,callback){
				debugger;
				$http({
					method: 'GET',
					url: ApiUrl+'/values/',
					params:{
							"id":1
						}
				}).then(function successCallback(response) {	
					debugger;
			    	// 请求成功执行代码
					callback(response);
				}, function errorCallback(response) {
					debugger;
					// 请求失败执行代码
					alert('error');
				});	
			}
		}	
}]);  