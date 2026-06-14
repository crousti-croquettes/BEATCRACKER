<?php
// By 0OMPHALOS @
	date_default_timezone_set('UTC');
	$UserName =(!empty($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (!empty($_POST['u']) ? $_POST['u'] : null);
	if(!empty($UserName) and !empty($ldatas)){
		$cnuset = $UserName;
		$UserName = strtolower($UserName);
		$spfile = '../Dbu/'.$UserName.'/mdma.p';
		if(file_exists($spfile)){
			chmod($spfile, 0400);
			$pccont = file_get_contents($spfile);
			chmod($spfile, 0000);
			$tmsOTiU = hash('sha256', $ldatas);
			if(hash_equals($tmsOTiU, $pccont)){
				$pccont = '';
				$admfile = '../Dbu/'.$UserName.'/fmdm.p';
				if(file_exists($admfile)){
					chmod($admfile, 0400);
					$pccont = file_get_contents($admfile);
					chmod($admfile, 0000);
					if(!empty($pccont)){
						$pccont = '';
						$mfolder = array_filter(glob('../Dbu/Pend/*'), 'is_dir');
						$vdatafs = '';
						foreach($mfolder as $foval){
							$fold = explode("/", $foval)[3];
							if(!empty($fold)){
								$files = array_filter(glob($foval.'/*'), 'is_file');
								foreach($files as $fival){
									if(!strpos($fival, '.p')){
										$nffo = explode("/", $fival)[3];
										$nfff = explode("/", $fival)[4];
										$vdatafs = $vdatafs.$nffo.":".$nfff.":".filesize($fival).";";
									}
								}
							}
						}
						echo $vdatafs;
					}
				}else{
					$vdatafs = '';
					$mfiles = array_filter(glob('../Dbu/Pend/'.$cnuset.'/*'), 'is_file');
					foreach($mfiles as $value){
						$fifold = explode("/", $value)[4];
						if(!empty($fifold)){
							if(!strpos($fifold, '.p')){
								$vdatafs = $vdatafs.$fifold.":".filesize($value).";";
							}
						}
					}
					echo $vdatafs;
				}
			}
		}
	}
	unset($_POST);
?>