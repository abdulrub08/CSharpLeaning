
String.prototype.wiFormat=function(){var pattern=/\{\d+\}/g;var args=arguments;return this.replace(pattern,function(capture){return args[capture.match(/\d+/)];});};if(!window.Wibiya){window.Wibiya={};Wibiya.framework={events:{documentIsReady:false,documentReadyHandler:function(fn){if(!Wibiya.framework.events.documentIsReady){Wibiya.framework.events.documentIsReady=true;if(document.addEventListener){document.removeEventListener("DOMContentLoaded",function(){Wibiya.framework.events.documentReadyHandler(fn);},false);}
else if(document.attachEvent){if(document.readyState=="complete"){document.detachEvent("onreadystatechange",function(){Wibiya.framework.events.documentReadyHandler(fn);});}}
fn();}},documentReady:function(fn){if(document.addEventListener){document.addEventListener("DOMContentLoaded",function(){Wibiya.framework.events.documentReadyHandler(fn);},false);window.addEventListener("load",function(){Wibiya.framework.events.documentReadyHandler(fn);},false);}else if(document.attachEvent){document.attachEvent("onreadystatechange",function(){Wibiya.framework.events.documentReadyHandler(fn);});window.attachEvent("onload",function(){Wibiya.framework.events.documentReadyHandler(fn);});var toplevel=false;try{toplevel=window.frameElement==null;}catch(e){}
if(document.documentElement.doScroll&&toplevel){Wibiya.framework.events.doScrollCheck(function(){Wibiya.framework.events.documentReadyHandler(fn);});}}},doScrollCheck:function(fn){if(Wibiya.framework.events.documentIsReady){return;}
try{document.documentElement.doScroll("left");}catch(error){window.setTimeout(function(){Wibiya.framework.events.doScrollCheck(fn);},1);return;}
fn();},bodyReadyTryCounter:0,bodyReady:function(fn){var bodyRef=document.getElementsByTagName("body");if(bodyRef.length==0){Wibiya.framework.events.bodyReadyTryCounter++;if(Wibiya.framework.events.bodyReadyTryCounter<=10){window.setTimeout(function(){Wibiya.framework.events.bodyReady(fn);},500);}}
else{fn();}},libraryReady:function(fn){if(!Wibiya.libraryReady){window.setTimeout(function(){Wibiya.framework.events.libraryReady(fn)},100);}
else{fn();}}},utils:{inArrayRegex:function(arr,str){if(typeof(arr)=='object'&&arr.length){var regExp;for(var i=0;i<arr.length;i++){regExp=new RegExp(arr[i],"i");if(regExp.test(str)){return i;}}}
return-1;},attachFile:function(fileref,toTagName){document.getElementsByTagName(toTagName)[0].appendChild(fileref);},attachJs:function(url,toTagName){var fileref=document.createElement("script");fileref.setAttribute("type","text/javascript");fileref.setAttribute("src",url);Wibiya.framework.utils.attachFile(fileref,toTagName);},attachCss:function(url,toTagName){var fileref=document.createElement("link");fileref.setAttribute("rel","stylesheet");fileref.setAttribute("type","text/css");fileref.setAttribute("href",url);Wibiya.framework.utils.attachFile(fileref,toTagName);},getQueryParam:function(name){var p,params=new Array(),qString=window.location.search.substring(1).split("&");for(var i=0;i<qString.length;i++){p=qString[i].split("=");params[p[0]]=p[1];}
return params[name]||'';},hasHashTag:function(name){return new RegExp("#"+name).test(window.location.hash);},isIE6:function(){var bmatch=/(msie) ([\w.]+)/i.exec(navigator.userAgent)||[];return bmatch.length>1&&parseInt(bmatch[2])==6;},setCookie:function(c_name,value,exdays){var exdate=new Date();exdate.setDate(exdate.getDate()+exdays);var c_value=escape(value)+((exdays==null)?"":"; expires="+exdate.toUTCString());document.cookie=c_name+"="+c_value;},getCookie:function(c_name){var i,x,y,ARRcookies=document.cookie.split(";");for(i=0;i<ARRcookies.length;i++){x=ARRcookies[i].substr(0,ARRcookies[i].indexOf("="));y=ARRcookies[i].substr(ARRcookies[i].indexOf("=")+1);x=x.replace(/^\s+|\s+$/g,"");if(x==c_name){return unescape(y);}}
return null;}},analytics:{loadUrlFormat:"http://wstat.wibiya.com/{0}.jpg?t={1}",loadType:{toolbar:'t',mobile:'m',mobileLive:'ml'},setLoad:function(loadType,containerId){var img=new Image(1,1);img.src=Wibiya.framework.analytics.loadUrlFormat.wiFormat(loadType,containerId);}}};Wibiya.loadContainers=function(){if(Wibiya.data.mobileAgent){if(Wibiya.data.mobileAgent=='iphone'&&Wibiya.data.containers.iphone!=''){Wibiya.framework.utils.attachJs(Wibiya.data.containers.iphone,"body");}
else{Wibiya.framework.analytics.setLoad(Wibiya.framework.analytics.loadType.mobile,Wibiya.data.site.id);}}
else{if(Wibiya.data.containers.toolbar!=''){Wibiya.framework.utils.attachJs(Wibiya.data.containers.toolbar,"body");}
if(Wibiya.data.containers.box!=''){Wibiya.framework.utils.attachJs(Wibiya.data.containers.box,"body");}
}};Wibiya.init=function(){if(Wibiya.framework.utils.getQueryParam("noredirectday")!=''){Wibiya.framework.utils.setCookie("noredirectday",'noredirect',1);}
var noRedirectDaily=Wibiya.framework.utils.getCookie('noredirectday')!==null;Wibiya.options.noRedirect=(Wibiya.framework.utils.getQueryParam("noredirect")!=''||Wibiya.framework.utils.hasHashTag("noredirect")||noRedirectDaily);if(Wibiya.options.preventLoad||(Wibiya.options.runMode=='hidden'&&Wibiya.framework.utils.getQueryParam('showbar')=='')){return;}
if(Wibiya.options.runMode=='debug'&&Wibiya.framework.utils.getQueryParam('widebug')==''){return;}
var mobileDevice=false,mobileDeviceIndex;mobileDeviceIndex=Wibiya.framework.utils.inArrayRegex(Wibiya.options.mobileDevices.supported,navigator.userAgent);if(mobileDeviceIndex>-1){mobileDevice=1;Wibiya.data.mobileAgent=Wibiya.options.mobileDevices.supported[mobileDeviceIndex];}
else{mobileDeviceIndex=Wibiya.framework.utils.inArrayRegex(Wibiya.options.mobileDevices.notSupported,navigator.userAgent);if(mobileDeviceIndex>-1){mobileDevice=0;Wibiya.data.mobileAgent=Wibiya.options.mobileDevices.supported[mobileDeviceIndex];}}
if(Wibiya.options.hasMobile&&mobileDevice===1&&Wibiya.options.mobileUrl&&!Wibiya.options.noRedirect){var url=window.location.href!=Wibiya.data.site.pages.main?window.location.href:'';window.location.href=Wibiya.options.mobileUrlFormat.wiFormat(Wibiya.options.mobileUrl,url,Wibiya.data.site.cms);}
if(mobileDevice===0){Wibiya.framework.analytics.setLoad(Wibiya.framework.analytics.loadType.mobile,Wibiya.data.siteId);return;}
if(Wibiya.framework.utils.isIE6()){return;}
if(Wibiya.options.loadOnDocumentReady){Wibiya.framework.events.documentReady(Wibiya.loadContainers);}
else{Wibiya.framework.events.bodyReady(Wibiya.loadContainers);}};Wibiya.options=window.wibiya_options||{};Wibiya.options.preventLoad=Wibiya.options.preventLoad||false;Wibiya.options.noRedirect=Wibiya.options.noRedirect||false;Wibiya.options.loadOnDocumentReady=false;Wibiya.options.hasMobile=true;Wibiya.options.mobileUrl='http://78d8a844-2b2b-49dc-9e48-25029a33d744.mobapp.at/Mobile';Wibiya.options.mobileUrlFormat="{0}?url={1}&cms={2}&timestamp=1340094939";Wibiya.options.runMode='standard';Wibiya.options.mobileDevices={supported:["iphone","android","ipod","windows phone"],notSupported:["windows ce","ipad","series60","symbian","palm","avantgo","docomo","vodafone","j-phone","xv6850","lg;","lge","mot","nintendo","blackberry","nokia","samsung","sonyericsson"]};Wibiya.data={userId:165924,containers:{toolbar:'http://cdn.wibiya.com/Toolbars/dir_0537/Toolbar_537491/toolbar_537491_1340094939.js',iphone:'',box:''},site:{id:537491,cms:'blogger',pages:{main:'http://asp-net-example.blogspot.com/',filter:null}}};Wibiya.init();}
window.loadjscssfile=function(filename,filetype,where){switch(filetype){case'js':Wibiya.framework.utils.attachJs(filename,where);break;case'css':Wibiya.framework.utils.attachCss(filename,where);break;}};window.getQueryParam=function(name){return Wibiya.framework.utils.getQueryParam(name);};window.wibiyaToolbar={};wibiyaToolbar.id=537491;wibiyaToolbar.referrer=document.referrer;wibiyaToolbar.framework={};window.WIBIYA={Mobile:{}};