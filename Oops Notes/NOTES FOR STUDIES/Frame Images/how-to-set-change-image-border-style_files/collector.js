var bt_width = screen.width;
var bt_height = screen.height;
var bt_referer = ""+document.referrer;
var bt_title = ""+document.title;
var bt_url = ""+document.location;
var bt_base_url = "http://tracker.icerocket.com/services/";
//var bt_base_url = "http://localhost/blogtracker/services/";
var gatherer_script = "gatherer.php";
var img_script = "img.php";

bt_referer = bt_referer.substring(0, 150);
bt_title = bt_title.substring(0, 150);
bt_url = bt_url.substring(0, 150);

bt_referer = escape(bt_referer);
bt_title = escape(bt_title);
bt_url = escape(bt_url);


if((!window.bt_counter_type) || (!window.bt_project_id)) {
	window.bt_error = 1;
}

if(window.bt_error!=1) {

	var bt_tracking_url = bt_base_url+gatherer_script+"?project_id="+bt_project_id+"&src=js"+"&resx="+bt_width+"&resy="+bt_height+"&referer="+bt_referer+"&url="+bt_url+"&title="+bt_title;

	bt_img = new Image();
	bt_img.src = bt_tracking_url;

	if (window.bt_counter_type==2) {
		if (!(window.bt_manc && window.bt_manc.match(/^([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$/))) {
			window.bt_manc='336699';
		}
		if (!(window.bt_manf && window.bt_manf.match(/^([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$/))) {
			window.bt_manf='000000';
		}
		if (!(window.bt_minc && window.bt_minc.match(/^([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$/))) {
			window.bt_minc='FFFFFF';
		}
		if (!(window.bt_minf && window.bt_minf.match(/^([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$/))) {
			window.bt_minf='FFFFFF';
		}
		if (!(window.bt_brdc && window.bt_brdc.match(/^([0-9a-fA-F]{3}|[0-9a-fA-F]{6})$/))) {
			window.bt_brdc='000000';
		}
		window.bt_manc = escape(bt_manc);
		window.bt_manf = escape(bt_manf);
		window.bt_minc = escape(bt_minc);
		window.bt_minf = escape(bt_minf);
		window.bt_brdc = escape(bt_brdc);
		var bt_img_src = bt_base_url+img_script+"?project_id="+bt_project_id+"&manc="+bt_manc+"&manf="+bt_manf+"&minc="+bt_minc+"&minf="+bt_minf+"&brdc="+bt_brdc;
		document.write("<a href=\"http://tracker.icerocket.com/project.info.php?pid="+bt_project_id+"&rid=pbl\"><img src=\""+bt_img_src+"\" width=100 height=36 border=0></a>");
	}
	window.bt_error = 1;
}
