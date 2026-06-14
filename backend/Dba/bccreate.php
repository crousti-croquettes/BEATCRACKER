<?php
	date_default_timezone_set('UTC');
	$UserName = (isset($_POST['n']) ? $_POST['n'] : null);
	$ldatas = (isset($_POST['p']) ? $_POST['p'] : null);
	$ldatac = (isset($_POST['t']) ? $_POST['t'] : null);
	$tipaddr = $_SERVER["REMOTE_ADDR"];
	$nfilei = "iprb/".$tipaddr.".pi";
	if(file_exists($nfilei)){
		$ipchkr = file_get_contents($nfilei);
		$tipadd = explode("|", $ipchkr)[0];
		$ttimip = explode("|", $ipchkr)[1];
	}else{
		$tipadd = 0;
	}
	if($tipadd <= "5"){
		if(!empty($UserName) and !empty($ldatas) and !empty($ldatac)){
			$UserName = strtolower($UserName);
			$target_dir = "../Dbu/".$UserName;
			if(file_exists($target_dir)){
				echo 'cExists!';
				$fip = fopen($nfilei, 'w');
				fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
				fclose($fip);
			}else{
				mkdir($target_dir, 0755);
				if(file_exists($target_dir)){
					$OneTimeUn = hash('sha256', rand(101, 999).rand(101,999).rand(101,999).rand(101, 999));
					$tmsOTiU = hash('sha256', $OneTimeUn);
					$tmtsp = hash('sha256', $ldatas);
					$nfilep = $target_dir."/pass.pass";
					$nfileu = $target_dir."/mdma.p";
					$nfilet = $target_dir."/time.p";
					$fa = fopen($nfilep, 'w');
					fwrite($fa, $tmtsp);
					fclose($fa);
					$fh = fopen($nfileu, 'w');
					fwrite($fh, $tmsOTiU);
					fclose($fh);
					$ft = fopen($nfilet, 'w');
					fwrite($ft, $ldatac);
					fclose($ft);
					chmod($nfilep, 0400);
					chmod($nfileu, 0400);
					chmod($nfilet, 0400);
					exec("chmod -R 0400 ".$nfilep);
					exec("chmod -R 0400 ".$nfileu);
					exec("chmod -R 0400 ".$nfilet);
					if(file_exists($nfilei)){
						unlink($nfilei);
					}
					echo "Completed!|".$OneTimeUn;
				}else{
					echo "Wrong";
					$fip = fopen($nfilei, 'w');
					fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
					fclose($fip);
				}
			}
		}else{
			$fip = fopen($nfilei, 'w');
			fwrite($fip, $tipadd + "1"."|".date("h:i:s"));
			fclose($fip);
		}
	}else{
		//Server date
		$ttfsm = explode(":", date("h:i:s"))[1];
		$ttfsh = explode(":", date("h:i:s"))[0];
		//IP banned date
		$tcimim = explode(":", $ttimip)[1];
		$tcimih = explode(":", $ttimip)[0];
		//Math
		if($ttfsh - $tcimih > 1){
			unlink($nfilei);
		}else{
			$tfileb = 60 - $tcimim;
			$tservd = 60 - $ttfsm;
			if(($tservd - $tfileb) < 0 or $tservd > $tfileb or $ttfsm > $tcimim){
				unlink($nfilei);
			}
		}
	}
	unset($_POST);
?>