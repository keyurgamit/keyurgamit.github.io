$(document).ready(function(){
	//$("#intro").typeIt({speed:50}).tiType("Hi I").tiPause(700).tiDelete(2).tiType(", I'm <span>Ravi patil</span>").tiBreak().tiPause(1e3).tiType("Front-end Designer &amp; Developer");
	$('#more').on('click',function(){
		$('#det').toggle(750);
		$('#more').hide();
		$('#less').show();

	});
	$('#less').on('click',function(){
		$('#det').toggle(750);
		$('#less').hide();
		$('#more').show();
	});
 });  

