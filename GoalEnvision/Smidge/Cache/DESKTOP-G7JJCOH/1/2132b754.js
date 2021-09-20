app.run(["$rootScope","$route","$location","urlHelper","navigationService","appState","assetsService","eventsService","$cookies","tourService","localStorageService",function($rootScope,$route,$location,urlHelper,navigationService,appState,assetsService,eventsService,$cookies,tourService,localStorageService){$.ajaxSetup({beforeSend:function(xhr){xhr.setRequestHeader("X-UMB-XSRF-TOKEN",$cookies["UMB-XSRF-TOKEN"]),xhr.setRequestHeader("X-Requested-With","XMLHttpRequest");var queryStrings=urlHelper.getQueryStringParams();"true"!==queryStrings.umbDebug&&"true"!==queryStrings.umbdebug||xhr.setRequestHeader("X-UMB-DEBUG","true")}}),eventsService.on("app.authenticated",function(evt,data){assetsService._loadInitAssets().then(function(){!function appReady(data){appState.setGlobalState("isReady",!0),eventsService.emit("app.ready",data),returnToPath=null,returnToSearch=null}(data),tourService.registerAllTours().then(function(){tourService.getTourByAlias("umbIntroIntroduction").then(function(introTour){if(introTour&&!0!==introTour.disabled&&!0!==introTour.completed)tourService.startTour(introTour),localStorageService.set("introTourShown",!0);else{localStorageService.get("introTourShown")||tourService.getTourByAlias("umbEmailMarketing").then(function(emailMarketingTour){if(emailMarketingTour&&!0!==emailMarketingTour.disabled&&!0!==emailMarketingTour.completed){localStorageService.get("emailMarketingTourShown")||(tourService.startTour(emailMarketingTour),localStorageService.set("emailMarketingTourShown",!0))}})}})})})});var currentRouteParams=null,originalTitle="";$rootScope.$on("$changeTitle",function(event,titlePrefix){$rootScope.locationTitle=titlePrefix?titlePrefix+" - "+originalTitle:originalTitle}),$rootScope.$on("$routeChangeSuccess",function(event,current,previous){var deployEnv,deployEnvTitle,toRetain=currentRouteParams?navigationService.retainQueryStrings(currentRouteParams,current.params):null;if(toRetain?($route.updateParams(toRetain),currentRouteParams=toRetain):currentRouteParams=Utilities.copy(current.params),Umbraco.Sys.ServerVariables.deploy&&(deployEnvTitle="("+(deployEnv=Umbraco.Sys.ServerVariables.deploy.CurrentWorkspace)+") "),current.params.section){var baseTitle=current.params.section.charAt(0).toUpperCase()+current.params.section.slice(1)+" - "+$location.$$host;$rootScope.locationTitle=deployEnv?deployEnvTitle+baseTitle:baseTitle}else deployEnv&&($rootScope.locationTitle=deployEnvTitle+"Umbraco - "+$location.$$host),$rootScope.locationTitle="Umbraco - "+$location.$$host;originalTitle=$rootScope.locationTitle}),$rootScope.$on("$routeChangeError",function(event,current,previous,rejection){if(rejection.path){event.preventDefault();var returnPath=null;("/login"==rejection.path||rejection.path.startsWith("/login/"))&&(returnPath=encodeURIComponent($location.url())),$location.path(rejection.path),returnPath&&$location.search("returnPath",returnPath)}}),$rootScope.$on("$routeUpdate",function(event,next){if(currentRouteParams){var toRetain=navigationService.retainQueryStrings(currentRouteParams,next.params);toRetain&&$route.updateParams(toRetain),navigationService.isRouteChangingNavigation(currentRouteParams,next.params)?$route.reload():(currentRouteParams=toRetain||Utilities.copy(next.params)).sr&&(currentRouteParams.sr=null,$route.updateParams(currentRouteParams))}else $route.reload()});var touchDevice=/android|webos|iphone|ipad|ipod|blackberry|iemobile|touch/i.test(navigator.userAgent.toLowerCase());appState.setGlobalState("touchDevice",touchDevice)}]);