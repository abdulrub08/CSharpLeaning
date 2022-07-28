/*1343161866,176820663*/

if (window.CavalryLogger) { CavalryLogger.start_js(["cG4oY"]); }

if(!window.CommentAdminPanelController){window.CommentAdminPanelController=function(a){copyProperties(this,{REAL_TIME_POLLING_DELAY:10000,locale:a.locale,channel:a.channel,controllerID:a.controllerID,commentIDs:a.commentIDs,domIDs:a.domIDs,blacklistedActors:a.blacklistedActors,actorToCommentInfoMap:a.actorToCommentIDMap,commentInfoMap:a.commentInfoMap,inAggregatedView:a.inAggregatedView,inModerationQueue:a.inModerationQueue,inContextualDialog:a.inContextualDialog,isPolling:false,loggedIn:a.loggedIn,newestCommentTimestamp:a.newestCommentTimestamp,realTimePollingParams:{},userOwnsPages:a.userOwnsPages,recentlyBlacklistedActors:a.blacklistedActors});this.controlledRegion=$(this.controllerID);this.attachClickHandlers();if(this.inModerationQueue)this.registerModeratorQueueHandlers(true);if(this.inContextualDialog)this.attachContextualDialogHandlers();if(!this.inAggregatedView)UnverifiedXD.init({autoResize:true,channelUrl:a.channel,hideOverflow:true,resizeWidth:false});};copyProperties(CommentAdminPanelController,{allControllers:{},mainController:null,contextualControllers:{},initController:function(a){var b=new CommentAdminPanelController(a),c=a.controllerID;CommentAdminPanelController.allControllers[c]=b;if(b.inContextualDialog){CommentAdminPanelController.contextualControllers[c]=b;}else CommentAdminPanelController.mainController=b;},syncController:function(a,b){var c=CommentAdminPanelController.allControllers[a];c.attachClickHandlers();if(!c.isControllingModerationQueue())return;c.deselectComments(b);c.registerModeratorQueueHandlers(false);c.synchronizeModeratorQueueUI();},resetController:function(a){var b=CommentAdminPanelController.allControllers[a];b.resetController();},updateController:function(a,b,c,d,e,f,g){var h=CommentAdminPanelController.allControllers[a];h.updateController(b,c,d,e,f,g);if(!CommentAdminPanelController.mainController.loggedIn)MultiLoginPopup.reattachLoginInterceptors();if(!h.isControllingModerationQueue())return;h.registerModeratorQueueHandlers(false);h.synchronizeModeratorQueueUI();},updatePollingParamsCommentas:function(a,b){var c=CommentAdminPanelController.allControllers[a];c.updatePollingParamsCommentas(b);},registerMoreCommentsLinkHandler:function(a,b){var c=CommentAdminPanelController.allControllers[a];c.registerMoreCommentsLinkHandler(b);},setRealTimePollingParams:function(a,b){var c=CommentAdminPanelController.allControllers[a];c.setRealTimePollingParams(b);},enableRealTimePolling:function(a){var b=CommentAdminPanelController.allControllers[a];b.enableRealTimePolling();},disableRealTimePolling:function(a){var b=CommentAdminPanelController.allControllers[a];b.disableRealTimePolling();},replaceContentMaybe:function(a,b){var c=DOM.scry(document.documentElement,a)[0];if(c)DOM.replace(c,b);},notifyCommentCreated:function(a){if(!CommentAdminPanelController.mainController.channel)return;UnverifiedXD.send({type:'commentCreated',href:a.href,parentCommentID:a.parentCommentID,commentID:a.commentID});},notifyCommentRemoved:function(a){if(!CommentAdminPanelController.mainController.channel)return;UnverifiedXD.send({type:'commentRemoved',href:a.href,commentID:a.commentID});},markAsShowingAllReplies:function(a){var b=a+' a.fbUpDownVoteOption',c=DOM.scry(document.documentElement,b),d=a+' li.fbUpDownVoteOption a.itemAnchor',e=DOM.scry(document.documentElement,d),f=c.concat(e);for(var g=0;g<f.length;g++){var h=f[g],i=new URI(h.getAttribute('ajaxify'));i.addQueryData({show_all_replies:1});h.setAttribute('ajaxify',i.toString());}},setLoggedIn:function(a){CommentAdminPanelController.mainController.loggedIn=a;}});copyProperties(CommentAdminPanelController.prototype,{isControllingModerationQueue:function(){var a=this==CommentAdminPanelController.mainController&&this.inModerationQueue;return a;},resetController:function(){this.commentIDs=[];this.domIDs=[];},updateController:function(a,b,c,d,e,f){a.forEach(function(h){this.commentIDs.push(h);},this);b.forEach(function(h){this.domIDs.push(h);},this);copyProperties(this.blacklistedActors,d);for(var g in e){if(!this.actorToCommentInfoMap[g])this.actorToCommentInfoMap[g]=[];e[g].forEach(function(h){this.actorToCommentInfoMap[g].push(h);},this);}this.newestCommentTimestamp=Math.max(this.newestCommentTimestamp,c);copyProperties(this.commentInfoMap,f);this.attachClickHandlers();},updatePollingParamsCommentas:function(a){this.realTimePollingParams.commentas=a;},attachClickHandlers:function(){for(var a=0;a<this.domIDs.length;a++){var b='li[id="'+this.domIDs[a]+'"]',c=DOM.scry(this.controlledRegion,b);if(c.length===0)continue;var d=c[0],e=DOM.scry(d,'a.uiCloseButton');Event.listen(d,'mouseleave',this.closeStickyMenuFlyouts.bind(this,e));var f=DOM.scry(d,'.fbModerateDropdownContainer');if(f.length>0){var g=f[0],h=DOM.find(g,'.fbModerateDropdownLink');Event.listen(h,'mouseover',function(q,event){CSS.addClass(q,'fbUnderlineText');}.curry(h));Event.listen(h,'mouseout',function(q,event){CSS.removeClass(q,'fbUnderlineText');}.curry(h));var i=DOM.find(g,'.fbModerationDropdownList');Event.listen(h,'click',this.exposeDropDownMenu.bind(this,h,i));Event.listen(i.parentNode,'mouseleave',this.concealDropDownMenu.bind(this,h,i));this.attachDropDownHandlers(d,this.commentIDs[a],i);}var j=this.commentInfoMap[this.commentIDs[a]].actor,k=!!this.recentlyBlacklistedActors[j];if(k){var l=DOM.scry(d,'.fbUndoBlacklistLink');if(l.length>0){var m=l[0];Event.listen(m,'click',this.toggleBlackListAndSync.bind(this,this.commentIDs[a]));}}}var n=DOM.scry(this.controlledRegion,'.fbReplyButton'),o=DOM.scry(this.controlledRegion,'.fbReplyAfterLoginButton');for(var p=0;p<n.length;p++)if(this.loggedIn){CSS.show(n[p]);CSS.hide(o[p]);}else{CSS.hide(n[p]);CSS.show(o[p]);}},closeStickyMenuFlyouts:function(a,event){Toggler.hide();for(var b=0;b<a.length;b++)a[b].blur();},attachDropDownHandlers:function(a,b,c){var d=DOM.scry(c,'.fbBanUser');if(d.length>0){var e=d[0],f=DOM.find(e,'^.fbFeedbackPost');if(startsWith(f.id,b))Event.listen(e,'click',this.toggleBlackListAndSync.bind(this,b));}},exposeDropDownMenu:function(a,b,event){if(CSS.shown(b))return this.concealDropDownMenu(a,b,event);Event.stop(event);CSS.show(b);b.focus();a.blur();return false;},concealDropDownMenu:function(a,b,event){Event.stop(event);CSS.removeClass(a,'fbUnderlineText');CSS.hide(b);a.blur();return false;},registerMoreCommentsLinkHandler:function(a){var b=a.pager_id;if(!ge(b))return;var c=$(b);Event.listen(c,'click',this.fetchMoreComments.bind(this,a,c));},deselectComments:function(a){for(var b=0;b<a.length;b++)delete this.selectedCommentsMap[a[b]];},registerModeratorQueueHandlers:function(a){if(a)this.selectedCommentsMap={};this.selectableComments=this.findSelectableComments();this.selectableCheckboxes=[];this.selectAllCheckBoxes=DOM.scry(this.controlledRegion,'.fbSelectAllCheckbox');this.approveButtons=DOM.scry(this.controlledRegion,'.fbApproveButton');this.removeButtons=DOM.scry(this.controlledRegion,'.fbRemoveButton');for(var b=0;b<this.selectableComments.length;b++){var c=this.selectableComments[b].id,d=!!this.selectedCommentsMap[c];this.setCommentSelection(this.selectableComments[b],d);var e=DOM.find(this.selectableComments[b],'.fbCommentCheckbox');Event.listen(e,'click',this.toggleCommentSelection.bind(this));Event.listen(this.selectableComments[b],'click',this.toggleCommentSelection.bind(this));e.checked=d;this.selectableCheckboxes.push(e);}for(var f=0;f<this.selectAllCheckBoxes.length;f++){this.selectAllCheckBoxes[f].checked=false;this.selectAllCheckBoxes[f].disabled=this.selectableComments.length===0;Event.listen(this.selectAllCheckBoxes[f],'click',this.toggleSelectAllCheckbox.bind(this,this.selectAllCheckBoxes[f]));}for(var g=0;g<this.approveButtons.length;g++)Event.listen(this.approveButtons[g],'click',this.setBulkPrivacy.bind(this,false));for(var h=0;h<this.removeButtons.length;h++)Event.listen(this.removeButtons[h],'click',this.setBulkPrivacy.bind(this,true));},findSelectableComments:function(){var a=DOM.scry(this.controlledRegion,'.fbTopLevelComment'),b=[];for(var c=0;c<a.length;c++)if((DOM.scry(a[c],'.fbCommentCheckbox').length===1)&&(DOM.scry(a[c],'.fbCommentOverlay').length===0))b.push(a[c]);return b;},toggleCommentSelection:function(event){var a={a:true},b=event.getTarget(),c=b.tagName.toLowerCase(),d=b.parentNode.tagName.toLowerCase();if(a[c]||a[d])return;var e=CSS.hasClass(b,'fbFeedbackPost')?b:DOM.find(b,'^.fbFeedbackPost'),f=this.commentIsSelected(e),g=!f;this.setCommentSelection(e,g);this.synchronizeModeratorQueueUI();if(CSS.hasClass(b,'fbCommentCheckbox'))Event.stop(event);},commentIsSelected:function(a){return CSS.hasClass(a,'fbCommentSelected');},setCommentSelection:function(a,b){if(b){this.selectComment(a);}else this.deselectComment(a);},selectComment:function(a){CSS.addClass(a,'fbCommentSelected');this.selectedCommentsMap[a.id]=true;DOM.find(a,'.fbCommentCheckbox').checked=true;},deselectComment:function(a){CSS.removeClass(a,'fbCommentSelected');delete this.selectedCommentsMap[a.id];DOM.find(a,'.fbCommentCheckbox').checked=false;},toggleSelectAllCheckbox:function(a,event){Event.stop(event);var b=a.checked;for(var c=0;c<this.selectableComments.length;c++){this.setCommentSelection(this.selectableComments[c],a.checked);this.selectableCheckboxes[c].checked=b;}this.synchronizeBulkModerationCheckboxes(b);this.synchronizeBulkModerationButtons(b);},synchronizeModeratorQueueUI:function(){var a=0;for(var b=0;b<this.selectableCheckboxes.length;b++)if(this.selectableCheckboxes[b].checked)a++;var c=this.selectableCheckboxes.length>0&&a==this.selectableCheckboxes.length;this.synchronizeBulkModerationCheckboxes(c);this.synchronizeBulkModerationButtons(a>0);},synchronizeBulkModerationCheckboxes:function(a){for(var b=0;b<this.selectAllCheckBoxes.length;b++)this.selectAllCheckBoxes[b].checked=a;},synchronizeBulkModerationButtons:function(a){for(var b=0;b<this.approveButtons.length;b++)Button.setEnabled(this.approveButtons[b],a);for(var c=0;c<this.removeButtons.length;c++)Button.setEnabled(this.removeButtons[c],a);},setBulkPrivacy:function(a,event){Event.stop(event);this.synchronizeBulkModerationButtons(false);selectedCommentIDs=[];for(var b in this.selectedCommentsMap)selectedCommentIDs.push(b);var c={is_private:a,in_moderation_queue:true,comment_ids:selectedCommentIDs,uniqids:selectedCommentIDs,controller_id:this.controllerID,locale:this.locale,owns_pages:this.userOwnsPages,in_aggregated_view:this.inAggregatedView,in_contextual_dialog:this.inContextualDialog};new AsyncRequest().setURI('/ajax/connect/comments/set_bulk_private.php').setData(c).send();return false;},toggleBlackListAndSync:function(a,event){Event.stop(event);var b=this.commentInfoMap[a].actor,c={blacklist:!this.blacklistedActors[b],in_moderation_queue:this.inModerationQueue,comment_id:a,other_comment_ids:this.getOtherCommentsByActor(b,a),uniqid:a,controller_id:this.controllerID,locale:this.locale,owns_pages:this.userOwnsPages,in_aggregated_view:this.inAggregatedView,in_contextual_dialog:this.inContextualDialog};new AsyncRequest().setURI('/ajax/connect/comments/set_blacklist.php').setData(c).setHandler(function(d){this.blacklistedActors[b]=!this.blacklistedActors[b];if(this.blacklistedActors[b]){this.recentlyBlacklistedActors[b]=true;}else delete this.recentlyBlacklistedActors[b];}.bind(this)).send();return false;},getOtherCommentsByActor:function(a,b){return this.actorToCommentInfoMap[a].filter(function(c){return c!=b;});},fetchMoreComments:function(a,b,event){Event.kill(event);CSS.addClass(b,'async_saving');var c={is_reply_thread:false,in_moderation_queue:false,view_as_moderator:false};copyProperties(c,a);c.recently_blacklisted=this.getRecentlyBlacklistedActors();c.offset=this.getVisibleCommentCount(c);if(!c.aggregate_view)delete c.aggregate_view;if(!c.comment_id)delete c.comment_id;if(!c.is_reply_thread)c.comment_ids=this.commentIDs;new AsyncRequest().setURI('/ajax/connect/feedback.php').setReadOnly(true).setData(c).send();},getVisibleCommentCount:function(a){var b=this.getCommentsSelector(a),c=this.getCollapsedCommentsSelector(a),d=DOM.scry($(a.controller_id),b);d=d.concat(DOM.scry($(a.controller_id),c));var e=0;for(var f=0;f<d.length;f++)if(!CSS.hasClass(d[f],'fbCommentIgnored'))e++;return e;},getCommentsSelector:function(a){var b=a.is_reply_thread?'li.fbCommentReply':'li.fbTopLevelComment';if(a.controller_id!=a.uniqid)b='div[id="'+a.uniqid+'"] '+b;return b;},getCollapsedCommentsSelector:function(a){var b=a.is_reply_thread?'div.fbCommentReply':'div.fbTopLevelComment';if(a.controller_id!=a.uniqid)b='div[id="'+a.uniqid+'"] '+b;return b;},getRecentlyBlacklistedActors:function(){var a=[];for(var b in this.recentlyBlacklistedActors)a.push(b);return a;},attachContextualDialogHandlers:function(){this.documentClickListener=Event.listen(document.documentElement,'click',this.closeContextualDialog.bind(this));},closeContextualDialog:function(event){var a=event.getTarget(),b=Parent.byClass(a,'fbCommentContext');if(!b)this.destroyContextualDialog();},destroyContextualDialog:function(){this.documentClickListener.remove();delete this.documentClickListener;var a=this.controllerID;Feedback.closeContextualDialog(a);},setRealTimePollingParams:function(a){this.realTimePollingParams=a;},enableRealTimePolling:function(){if(!this.isPolling){this.isPolling=true;this.schedulePolling(this.REAL_TIME_POLLING_DELAY);}},disableRealTimePolling:function(){if(this.isPolling){this.isPolling=false;clearTimeout(this.realTimePollingTimeout);}},schedulePolling:function(a){var b=this.realTimePollingParams;this.realTimePollingTimeout=setTimeout(this.pollForComments.bind(this,b),a);},pollForComments:function(a){data={locale:this.locale,command:'poll'};copyProperties(data,a);data.recently_blacklisted=this.getRecentlyBlacklistedActors();if(!data.is_reply_thread)data.comment_ids=this.commentIDs;data.newest_comment_timestamp=this.newestCommentTimestamp;handler=this.handlePollResponse.bind(this);errorHandler=this.handlePollError.bind(this);finallyHandler=this.handlePollFinally.bind(this);new AsyncRequest().setURI('/plugins/comments/poll').setReadOnly(true).setData(data).setMethod('GET').setHandler(handler).setErrorHandler(errorHandler).setFinallyHandler(finallyHandler).send();},handlePollResponse:function(a){},handlePollError:function(a){},handlePollFinally:function(a){this.schedulePolling(this.REAL_TIME_POLLING_DELAY);}});}
add_properties('Feedback',{registerComment:function(a,b){Feedback.comments[a]=b;return Feedback;},getRegisteredComment:function(a){return Feedback.comments[a];},deleteClickHandler:function(a,b,c,d,e,f){var g=new Dialog().setTitle("Delete post?").setBody("Are you sure you want to delete this post?").setButtons([Dialog.newButton('delete',"Delete"),Dialog.CANCEL]).setHandler(function(event){new AsyncRequest().setURI('/ajax/connect/feedback.php').setData({command:'delete',url:a,uniqid:d,owns_pages:e,controller_id:c,locale:f,comment_id:b}).send();}.bind(this)).show();},resizeCommentas:function(a){var b=DOM.scry(a,'div.post')[0];if(b){var c=Vector2.getElementDimensions(b).x;if(c){var d=DOM.find(b,'.commentas'),e=Vector2.getElementDimensions(d).x;if((c-e)<190&&(c-190)>60){Style.set(d,'width',c-190+'px');var f=DOM.scry(d,'span.commentas_inner')[0];if(f){var g=Vector2.getElementDimensions(f).x;Style.set(d,'width',g+'px');}}}}},exposeContextualDialogReply:function(a){var b=$(a),c=b.parentNode.parentNode;CSS.show(DOM.find(c,"form"));DOM.find(c,"textarea").focus();return false;},concealContextualDialogReply:function(a){var b=$(a),c=b.parentNode.parentNode,d=DOM.find(c,"form"),e=DOM.find(c,"textarea"),f=e.value.length;if(!Input.getValue(e))CSS.hide(d);return false;},closeContextualDialog:function(a){var b=ContextualDialogX.getInstance($(a));b.hide();return false;},_clickLocked:false,attachOptInClickListener:function(a){Event.listen(a,'click',function(b){Event.kill(b);if(!this._clickLocked){this._clickLocked=true;setTimeout(function(){this._clickLocked=false;}.bind(this),1000);PlatformOptInPopup.open('feedback','opt.in');}});},attachReplyListener:function(a){if(!a)return;var b=DOM.find(a,'textarea');a.suppressBlur=false;Event.listen(a,'click',function(c){var d=c.getTarget(),e=Parent.byClass(d,'commentas')!==null,f=Parent.byClass(d,'uiButton')!==null,g=Parent.byClass(d,'uiSelector')!==null;a.suppressBlur=e||f||g;});Event.listen(b,'blur',function(c,d){if(a.interval)return;a.interval=setInterval((function(e,f){if(e.suppressBlur||Input.getValue(f)||f==document.activeElement)return;CSS.hide(e);e.suppressBlur=false;clearInterval(e.interval);delete e.interval;}).curry(a,c),100);}.curry(b));},attachReplyClickListener:function(a,b,c){if(!a)return;var d=DOM.find(a,'textarea');Event.listen(b,'click',function(e){CSS.show(a);d.focus();if(!c.isViewer&&c.isReply){var f=MentionsInput.getInstance(d);if(f){var g=f.getMentions();if(!g[c.uid]&&Input.getValue(d)===''){f.addMention(c);Input.setValue(d,Input.getValue(d)+' ');}}else Input.setValue(d,c.text+' ');}e.preventDefault();});},resetInput:function(a){var b=MentionsInput.getInstance(a);if(b){b.reset({flattened:'',mention_data:{}});}else Input.setValue(a,'');}});if(!window.Feedback.comments)window.Feedback.comments={};
__d("sprintf",[],function(a,b,c,d,e,f){function g(h,i){i=Array.prototype.slice.call(arguments,1);var j=0;return h.replace(/%s/g,function(k){return i[j++];});}e.exports=g;});
__d("Log",["sprintf"],function(a,b,c,d,e,f){var g=b('sprintf'),h={DEBUG:3,INFO:2,WARNING:1,ERROR:0};function i(k,l){var m=Array.prototype.slice.call(arguments,2),n=g.apply(null,m);if(j.level>=k&&window.console)console[l in console?l:'log'](n);}var j={level:-1,Level:h,debug:i.bind(null,h.DEBUG,'debug'),info:i.bind(null,h.INFO,'debug'),warn:i.bind(null,h.WARNING,'debug'),error:i.bind(null,h.ERROR,'debug')};e.exports=j;});
__d("resolveWindow",[],function(a,b,c,d,e,f){function g(h){var i=window,j=h.split('.');try{for(var l=0;l<j.length;l++){var m=j[l],n=/^frames\[['"]?([a-zA-Z0-9\-_]+)['"]?\]$/.exec(m);if(n){i=i.frames[n[1]];}else if(m==='opener'||m==='parent'||m==='top'){i=i[m];}else return null;}}catch(k){return null;}return i;}e.exports=g;});
__d("XD",["function-extensions","Arbiter","DOM","DOMDimensions","Log","URI","UserAgent","copyProperties","isInIframe","resolveWindow"],function(a,b,c,d,e,f){b('function-extensions');var g=b('Arbiter'),h=b('DOM'),i=b('DOMDimensions'),j=b('Log'),k=b('URI'),l=b('UserAgent'),m=b('copyProperties'),n=b('isInIframe'),o=b('resolveWindow'),p='fb_xdm_frame_'+location.protocol.replace(':',''),q={_callbacks:[],_opts:{autoResize:false,allowShrink:true,channelUrl:null,hideOverflow:false,resizeTimeout:100,resizeWidth:false,expectResizeAck:false,resizeAckTimeout:6000},_lastResizeAckId:0,_resizeCount:0,_resizeTimestamp:0,_shrinker:null,init:function(s){this._opts=m(m({},this._opts),s);if(this._opts.autoResize)this._startResizeMonitor();g.subscribe('Connect.Unsafe.resize.ack',function(t,u){if(!u.id)u.id=this._resizeCount;if(u.id>this._lastResizeAckId)this._lastResizeAckId=u.id;}.bind(this));},send:function(s,t){t=t||this._opts.channelUrl;if(!t)return;var u={},v=new k(t);m(u,s);m(u,k.explodeQuery(v.getFragment()));var w=new k(u.origin),x=w.getDomain()+(w.getPort()?':'+w.getPort():''),y=o(u.relation.replace(/^parent\./,'')),z=y.frames[p];z?z.proxyMessage(k.implodeQuery(u),[x]):j.warn('No such frame "'+p+'" to proxyMessage to');},_computeSize:function(){var s=i.getDocumentDimensions(),t=0;if(this._opts.resizeWidth){var u=document.body;if(u.clientWidth<u.scrollWidth){t=s.width;}else{var v=u.childNodes;for(var w=0;w<v.length;w++){var x=v[w],y=x.offsetLeft+x.offsetWidth;if(y>t)t=y;}}t=Math.max(t,q.forced_min_width);}s.width=t;if(this._opts.allowShrink){if(!this._shrinker)this._shrinker=h.create('div');h.appendContent(document.body,this._shrinker);s.height=Math.max(this._shrinker.offsetTop,0);}return s;},_startResizeMonitor:function(){var s,t=document.documentElement;if(this._opts.hideOverflow){t.style.overflow='hidden';document.body.style.overflow='hidden';}setInterval((function(){var u=this._computeSize(),v=Date.now(),w=this._lastResizeAckId<this._resizeCount&&(v-this._resizeTimestamp)>this._opts.resizeAckTimeout;if(!s||(this._opts.expectResizeAck&&w)||(this._opts.allowShrink&&s.width!=u.width)||(!this._opts.allowShrink&&s.width<u.width)||(this._opts.allowShrink&&s.height!=u.height)||(!this._opts.allowShrink&&s.height<u.height)){s=u;this._resizeCount++;this._resizeTimestamp=v;var x={type:'resize',height:u.height,ackData:{id:this._resizeCount}};if(u.width&&u.width!=0)x.width=u.width;try{if(k(document.referrer).isFacebookURI()&&n()&&window.name&&window.parent.location&&window.parent.location.toString&&k(window.parent.location).isFacebookURI()){var z=window.parent.document.getElementsByTagName('iframe');for(var aa=0;aa<z.length;aa=aa+1)if(z[aa].name==window.name){if(this._opts.resizeWidth)z[aa].style.width=x.width+'px';z[aa].style.height=x.height+'px';}}this.send(x);}catch(y){this.send(x);}}}).bind(this),this._opts.resizeTimeout);}},r=m({},q);e.exports.UnverifiedXD=r;e.exports.XD=q;a.UnverifiedXD=r;a.XD=q;});
__d("legacy:connect-xd",["XD"],function(a,b,c,d){a.UnverifiedXD=b('XD').UnverifiedXD;a.XD=b('XD').XD;},3);
WindowComm={_callbacks:{},makeHandler:function(a,b){b=b||'opener';var c='f'+(Math.random()*(1<<30)).toString(16).replace('.','');WindowComm._callbacks[c]=a;return new URI('/connect/window_comm.php').setQueryData({_id:c,_relation:b}).getQualifiedURI().toString();},_recv:function(a){var b=new URI(a).getQueryData();WindowComm._callbacks[b._id](b);}};
__d("PopupWindow",["DOMDimensions","DOMQuery","UserAgent","copyProperties"],function(a,b,c,d,e,f){var g=b('DOMDimensions'),h=b('DOMQuery'),i=b('UserAgent'),j=b('copyProperties'),k={_opts:{allowShrink:true,strategy:'vector',timeout:100,widthElement:null},init:function(l){j(k._opts,l);setInterval(k._resizeCheck,k._opts.timeout);},_resizeCheck:function(){var l=g.getViewportDimensions(),m=k._getDocumentSize(),n=m.height-l.height,o=m.width-l.width;if(o<0&&!k._opts.widthElement)o=0;o=o>1?o:0;if(!k._opts.allowShrink&&n<0)n=0;if(n||o)try{window.console&&window.console.firebug;window.resizeBy(o,n);if(o)window.moveBy(o/-2,0);}catch(p){}},_getDocumentSize:function(){var l=g.getDocumentDimensions();if(k._opts.strategy==='offsetHeight')l.height=document.body.offsetHeight;if(k._opts.widthElement){var m=h.scry(document.body,k._opts.widthElement)[0];if(m)l.width=g.getElementDimensions(m).width;}if(window.Dialog&&Dialog.max_bottom&&Dialog.max_bottom>l.height)l.height=Dialog.max_bottom;return l;},open:function(l,m,n){var o=typeof window.screenX!='undefined'?window.screenX:window.screenLeft,p=typeof window.screenY!='undefined'?window.screenY:window.screenTop,q=typeof window.outerWidth!='undefined'?window.outerWidth:document.body.clientWidth,r=typeof window.outerHeight!='undefined'?window.outerHeight:(document.body.clientHeight-22),s=parseInt(o+((q-n)/2),10),t=parseInt(p+((r-m)/2.5),10),u=('width='+n+',height='+m+',left='+s+',top='+t);return window.open(l,'_blank',u);}};e.exports=k;});
__d("legacy:popup-resizer",["PopupWindow"],function(a,b,c,d){a.PopupResizer=b('PopupWindow');},3);
ConnectLogin={init:function(a){this.appID=a.appID;this.addToProfile=a.addToProfile;this.oneClick=a.oneClick;this.channelUrl=a.channelUrl;XD.init(a);},login:function(a,b,c){if(this.oneClick&&!b){this._oneClick(a);}else this._openPopup(a,b,c);},logout:function(){XD.send({type:'logout'});},_oneClick:function(a){new AsyncRequest().setURI('/ajax/api/tos.php').setData({app_id:this.appID,grant_perm:1}).setHandler(function(b){ConnectLogin._refreshLoginStatus();a&&a();}).send();},_openPopup:function(a,b,c){c=c||{};var d=WindowComm.makeHandler(function(h){ConnectLogin._closePopup();if(ConnectLogin.appID)ConnectLogin._refreshLoginStatus();a&&a();}),e=WindowComm.makeHandler(function(h){ConnectLogin._closePopup();}),f=new URI('/login.php');f.setQueryData({api_key:this.appID,next:d,channel_url:e,cancel_url:e,req_perms:b,v:'1.0',fbconnect:1,add_to_profile:this.addToProfile,display:'popup'});f.addQueryData(c);var g=this._getSize(c);this._popup=PopupResizer.open(f.toString(),g.height,g.width);},_closePopup:function(){if(this._popup){this._popup.close();this._popup=null;}},_refreshLoginStatus:function(){if(this.channelUrl){XD.send({type:'refreshLoginStatus'});}else window.location.reload();},_getSize:function(a){if(a.social_plugin=='registration'){return {width:640,height:370};}else return {width:610,height:280};}};
__d("legacy:startsWith",["startsWith"],function(a,b,c,d){a.startsWith=b('startsWith');},3);
WidgetArbiter={_findSiblings:function(){if(WidgetArbiter._siblings)return;WidgetArbiter._siblings=[];for(var a=parent.frames.length-1;a>=0;a--)try{if(parent.frames[a]&&parent.frames[a].Arbiter&&parent.frames[a].Arbiter.inform)WidgetArbiter._siblings.push(parent.frames[a].Arbiter);}catch(b){}},inform:function(){WidgetArbiter._findSiblings();var a=$A(arguments);WidgetArbiter._siblings.forEach(function(b){b.inform.apply(b,a);});}};
__d("legacy:primer",["Primer"],function(a,b,c,d){b('Primer');},3);
__d("DOMEventListener",[],function(a,b,c,d,e,f){var g,h;if(window.addEventListener){g=function(j,k,l){j.addEventListener(k,l,false);};h=function(j,k,l){j.removeEventListener(k,l,false);};}else if(window.attachEvent){g=function(j,k,l){j.attachEvent('on'+k,l);};h=function(j,k,l){j.detachEvent('on'+k,l);};}var i={add:function(j,k,l){g(j,k,l);return {remove:function(){h(j,k,l);j=null;}};},remove:h};e.exports=i;});
__d("UnverifiedXD",["XD","XDUnverifiedChannel"],function(a,b,c,d,e,f){var g=b('XD').UnverifiedXD,h=c('XDUnverifiedChannel').channel;g.init({channelUrl:h});e.exports=g;});
__d("PluginResize",["Log","UnverifiedXD","bind","copyProperties","curry"],function(a,b,c,d,e,f){var g=b('Log'),h=b('UnverifiedXD'),i=b('bind'),j=b('copyProperties'),k=b('curry');function l(o){o=o||document.body;return o.offsetWidth+o.offsetLeft;}function m(o){o=o||document.body;return o.offsetHeight+o.offsetTop;}function n(o,p,event){this.calcWidth=o||l;this.calcHeight=p||m;this.width=undefined;this.height=undefined;this.event=event||'resize';}j(n.prototype,{resize:function(){var o=this.calcWidth(),p=this.calcHeight();if(o!==this.width||p!==this.height){g.debug('Resizing Plugin: (%s, %s, %s)',o,p,this.event);this.width=o;this.height=p;h.send({type:this.event,width:o,height:p});}return this;},auto:function(o){setInterval(i(this,this.resize),o||250);return this;}});n.auto=function(o,event,p){return new n(k(l,o),k(m,o),event).resize().auto(p);};n.autoHeight=function(o,p,event,q){return new n(function(){return o;},k(m,p),event).resize().auto(q);};e.exports=n;});
__d("PluginShareButton",["DOMEvent","DOMEventListener","PluginResize","PopupWindow","UserAgent"],function(a,b,c,d,e,f){var g=b('DOMEvent'),h=b('DOMEventListener'),i=b('PluginResize'),j=b('PopupWindow'),k=b('UserAgent'),l={listen:function(m,n){var o=m.href;h.add(m,'click',function(p){new g(p).kill();j.open(o,340,670);});},resize:function(m){var n=k.firefox()||k.ie()>=9?1:0;new i(function(){return m.offsetWidth+m.offsetLeft+n;},function(){return m.offsetHeight+m.offsetTop;}).resize().auto();}};e.exports=l;});
__d("PluginXDReady",["Arbiter","UnverifiedXD"],function(a,b,c,d,e,f){var g=b('Arbiter'),h=b('UnverifiedXD'),i={handleMessage:function(j){if(!j.method)return;try{g.inform('Connect.Unsafe.'+j.method,JSON.parse(j.params),g.BEHAVIOR_PERSISTENT);}catch(k){}}};a.XdArbiter=i;h.send({xd_action:'plugin_ready',name:window.name});e.exports=null;});
__d("PluginPerms",["DOMEvent","DOMEventListener","PopupWindow","URI","bind","copyProperties"],function(a,b,c,d,e,f){var g=b('DOMEvent'),h=b('DOMEventListener'),i=b('PopupWindow'),j=b('URI'),k=b('bind'),l=b('copyProperties');function m(n,o){l(this,{return_params:j.getRequestURI().getQueryData(),login_params:{},perms_params:{},perms:[],plugin:n,app:o});this.addReturnParams({ret:'perms'});delete this.return_params.hash;}l(m.prototype,{addReturnParams:function(n){l(this.return_params,n);},addLoginParams:function(n){l(this.login_params,n);},addPermsParams:function(n){l(this.perms_params,n);},addPerms:function(n){this.perms.push.apply(this.perms,n);},start:function(){var n=j('/dialog/plugin.perms').addQueryData(this.perms_params).addQueryData({display:'popup',app_id:this.app,perms:this.perms.join(','),secure:j.getRequestURI().isSecure(),social_plugin:this.plugin,return_params:JSON.stringify(this.return_params),login_params:JSON.stringify(this.login_params)});this.popup=i.open(n.toString(),210,450);}});m.starter=function(n,o,p,q,r,s){var t=new m(n,o);t.addReturnParams(q||{});t.addLoginParams(r||{});t.addPermsParams(s||{});t.addPerms(p||[]);return k(t,t.start);};m.listen=function(n,o,p,q,r,s,t){h.add(n,'click',function(u){new g(u).kill();m.starter(o,p,q,r,s,t)();});};e.exports=m;});