import { Component, OnInit } from '@angular/core';
import { BikeService } from '../_services/bike.service';
import { HttpClient } from '@angular/common/http'
import { environment } from 'src/environments/environment';
import { Bike } from '../_model/Bike';
import { AlertifyService } from '../_services/alertify.service';
import { ProfileService } from '../_services/profile.service';

@Component({
  selector: 'app-bike-list',
  templateUrl: './bike-list.component.html',
  styleUrls: ['./bike-list.component.css']
})
export class BikeListComponent implements OnInit {

  baseUrl = environment.apiUrl + 'bike/GetBike'
  constructor(private bike_service: BikeService,private http: HttpClient,
    private alertify: AlertifyService) { }


   BikeList : Bike;
   selected_item: number = 0;
   selected_city_index :number = 0;
   selected_country_index:number = 0;
   selected_type_index:number = 0;
   selected_capacity_index:number = 0;
   selected_manufacture_index:number = 0;
   cost: number=0;
   srch: string="";
  
   bike_man_array = [
     "BMW",
     "Harley-Davidson",
     "Kawasaki"
   ];

   cities_array = [
     "Все",
    "Астана",
    "Алматы"
   ];

   country_array = [
    "Любой",
   "Германия",
   "Сша",
   "Китай"
  ];

  type_array = [
    "Любой",
   "Классика",
   "СпортБайк",
   "Круизер",
   "Чоппер"
  ];


  capacity_array = [
    "Любой",
   "от 50",
   "от 72-110",
   "от 125",
   "от 150-200",
   "от 250",
   "от 300",
   "от 350",
   "от 400",
   "от 450",
   "от 500",
   "от 550",
   "от 600",
   "от 650",
   "от 700",
   "от 750",
   "от 800",
   "от 850",
   "от 900",
   "от 950",
   "от 1000",
   "от 1050",
   "от 1100",
   "от 1150",
   "от 1200",
   "от 1200+"
  ];


  manufacture_array = [
    "Любой", 
    "BMW",
     "Harley-Davidson",
     "Kawasaki"
  ];
    


  ngOnInit() {
     this.selectionManufacture(0);
  }

  onSelected(bike: Bike)
  {
    this.alertify.message(bike.id.toString());
  }

  

  selectionManufacture(index: number){
      this.selected_item=index;
      this.bike_service.getBikeManList(this.bike_man_array[index]).subscribe((responce:Bike)=>{
        this.BikeList = responce;
     },error =>{
        this.alertify.error("Сервер не отвечаеть (Не можеть получить список мото-в)");
     });

     
   };

   ActiveItem(index: number):boolean
   {
     if(this.selected_item==index){return true;}
     return false;
   }

   selected_city(index: number){
      this.selected_city_index = index;
      console.log(index);
   }

   selected_county(index: number)
   {
     this.selected_country_index = index;
   }

   selected_type(index: number)
   {
     this.selected_type_index = index;
   }
   
   selected_capacity(index: number)
   {
     this.selected_capacity_index = index;
   }
   selected_manufacture(index: number)
   {
     this.selected_manufacture_index = index;
   }







   FindBike()
   {
     this.bike_service.getFindBikeList(this.srch,this.cost,this.cities_array_req[this.selected_city_index],
      this.country_array_req[this.selected_country_index],this.capacity_array_req[this.selected_capacity_index],
      this.type_array_req[this.selected_type_index],this.manufacture_array_req[this.selected_manufacture_index])
      .subscribe((responce:Bike)=>{
           console.log(responce);
          this.BikeList = responce;
       },error =>{
          console.log(error.error);
          
          this.alertify.error("Сервер не отвечаеть (Не можеть получить список мото-в)");
       }
      );



      
   }


   cities_array_req = [
    "",
   "Astana",
   "Almaty"
  ];

  country_array_req = [
     "",
   "Germany",
   "Usa",
   "China"
  ];

  type_array_req = [
    "",
   "Classic",
   "SportBike",
   "Cruiser",
   "Chopper"
  ];


  capacity_array_req = [
    0,
    50,
   100,
   150,
   200,
   250,
   300,
   350,
   400,
   450,
   500,
   550,
   600,
   650,
   700,
   750,
   800,
   850,
   900,
   950,
   1000,
   1050,
   1100,
   1150,
   1200,
   1200
  ];


  manufacture_array_req = [
    "", 
    "BMW",
     "Harley-Davidson",
     "Kawasaki"
  ];


}

