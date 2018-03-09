var Enemy:Transform;
public var Timer:float;
private var cooldown:int = 5;

function Awake(){
	Timer = Time.time + cooldown;
}

function Update(){
	if(Timer < Time.time){
		Instantiate(Enemy, transform.position,transform.rotation);
		Timer = Time.time + cooldown;
		if(cooldown > 1) {
			cooldown--;
		}
	}
}
