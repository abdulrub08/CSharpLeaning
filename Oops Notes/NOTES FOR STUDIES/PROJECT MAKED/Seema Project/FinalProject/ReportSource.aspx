﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReportSource.aspx.cs" Inherits="ReportSource" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Slides, A Slideshow Plugin for jQuery</title>
	
	<link rel="stylesheet" href="css/global.css">
	
	<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.5.1/jquery.min.js"></script>
	<script src="js/slides.min.jquery.js"></script>
	<script>
	    $(function () {
	        $('#slides').slides({
	            preload: true,
	            preloadImage: 'img/loading.gif',
	            play: 5000,
	            pause: 2500,
	            hoverPause: true,
	            animationStart: function (current) {
	                $('.caption').animate({
	                    bottom: -35
	                }, 100);
	                if (window.console && console.log) {
	                    // example return of current slide number
	                    console.log('animationStart on slide: ', current);
	                };
	            },
	            animationComplete: function (current) {
	                $('.caption').animate({
	                    bottom: 0
	                }, 200);
	                if (window.console && console.log) {
	                    // example return of current slide number
	                    console.log('animationComplete on slide: ', current);
	                };
	            },
	            slidesLoaded: function () {
	                $('.caption').animate({
	                    bottom: 0
	                }, 200);
	            }
	        });
	    });
	</script>
    </head>
    <body>
    <div id="container">
		<div id="example">
			<img src="img/new-ribbon.png" width="112" height="112" alt="New Ribbon" id="ribbon">
			<div id="slides">
				<div class="slides_container">
					<div class="slide">
						<a href="http://www.flickr.com/photos/jliba/4665625073/" title="145.365 - Happy Bokeh Thursday! | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-1.jpg" width="570" height="270" alt="Slide 1"></a>
						<div class="caption" style="bottom:0">
							<p>Happy Bokeh Thursday!</p>
						</div>
					</div>
					<div class="slide">
						<a href="http://www.flickr.com/photos/stephangeyer/3020487807/" title="Taxi | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-2.jpg" width="570" height="270" alt="Slide 2"></a>
						<div class="caption">
							<p>Taxi</p>
						</div>
					</div>
					<div class="slide">
						<a href="http://www.flickr.com/photos/childofwar/2984345060/" title="Happy Bokeh raining Day | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-3.jpg" width="570" height="270" alt="Slide 3"></a>
						<div class="caption">
							<p>Happy Bokeh raining Day</p>
						</div>
					</div>
					<div class="slide">
						<a href="http://www.flickr.com/photos/b-tal/117037943/" title="We Eat Light | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-4.jpg" width="570" height="270" alt="Slide 4"></a>
						<div class="caption">
							<p>We Eat Light</p>
						</div>
					</div>
					<div class="slide">
						<a href="http://www.flickr.com/photos/bu7amd/3447416780/" title="&ldquo;I must go down to the sea again, to the lonely sea and the sky; and all I ask is a tall ship and a star to steer her by.&rdquo; | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-5.jpg" width="570" height="270" alt="Slide 5"></a>
						<div class="caption">
							<p>&ldquo;I must go down to the sea again, to the lonely sea and the sky...&rdquo;</p>
						</div>
					</div>
					<div class="slide">
						<a href="http://www.flickr.com/photos/streetpreacher/2078765853/" title="twelve.inch | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-6.jpg" width="570" height="270" alt="Slide 6"></a>
						<div class="caption">
							<p>twelve.inch</p>
						</div>
					</div>
					<div class="slide">
						<a href="http://www.flickr.com/photos/aftab/3152515428/" title="Save my love for loneliness | Flickr - Photo Sharing!" target="_blank"><img src="img/slide-7.jpg" width="570" height="270" alt="Slide 7"></a>
						<div class="caption">
							<p>Save my love for loneliness</p>
						</div>
					</div>
				</div>
				<a href="#" class="prev"><img src="img/arrow-prev.png" width="24" height="43" alt="Arrow Prev"></a>
				<a href="#" class="next"><img src="img/arrow-next.png" width="24" height="43" alt="Arrow Next"></a>
			</div>
			<img src="img/example-frame.png" width="739" height="341" alt="Example Frame" id="frame">
		</div>
	</div>	
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <h3>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            Login Name * :&nbsp;
            <asp:TextBox ID="txtloginname" runat="server"></asp:TextBox>
        </h3>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" 
                ForeColor="#CC0000"></asp:Label>
        </p>
        <p>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                Text="Activate User" />
            &nbsp;</p>
    
    </div>
    </form>
</body>
</html>
