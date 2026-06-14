<?php
// By 0OMPHALOS @
	date_default_timezone_set('UTC');
	$UserName =(!empty($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (!empty($_POST['u']) ? $_POST['u'] : null);
	if(!empty($UserName)){
		$cnuset = $UserName;
		$UserName = strtolower($UserName);
		$spfile = '../Dbu/'.$UserName.'/mdma.p';
		if(file_exists($spfile)){
			chmod($spfile, 0400);
			$pccont = file_get_contents($spfile);
			$tmsOTiU = hash('sha256', $ldatas);
			if(hash_equals($tmsOTiU, $pccont)){
				chmod($spfile, 0000);
				$mfolder = array_filter(glob('../Drumkit/*'), 'is_dir');
				$vdatafs = '';
				foreach($mfolder as $foval){
					$fold = explode("/", $foval)[2];
					if(!empty($fold)){
						$files = array_filter(glob($foval.'/*'), 'is_file');
						foreach($files as $fival){
							$nffo = explode("/", $fival)[2];
							$nfff = explode("/", $fival)[3];
							$vdatafs = $vdatafs.$nffo.":".$nfff.":".filesize($fival).";";
						}
					}
				}
				$mfiles = array_filter(glob('../Drumkit/*'), 'is_file');
				foreach($mfiles as $value){
					$fifold = explode("/", $value)[2];
					if(!empty($fifold)){
						$vdatafs = $vdatafs."Unknown:".$fifold.":".filesize($value).";";
					}
				}
				echo $vdatafs;
			}else{
				chmod($spfile, 0000);
			}
		}
	}
	unset($_POST);
?>