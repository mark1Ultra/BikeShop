import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { AuthService } from './auth.service';
import { User } from '../_model/User';

@Injectable({
  providedIn: 'root'
})
export class ProfileService {

  constructor(private http: HttpClient,private authService: AuthService) { }

    
  profileurl = environment.apiUrl+"profile/";
    
   
    getprofile()
    {

      const httpOptions = {
        headers: new HttpHeaders({
          'Authorization': 'Bearer ' + localStorage.getItem('token')
        })
      };


      return this.http.get(this.profileurl+"GetCurrentUser",httpOptions);
    }

    getavatar()
    {
      const httpOptions = {
        headers: new HttpHeaders({
          'Authorization': 'Bearer ' + localStorage.getItem('token')
        })
      };

      return this.http.get(this.profileurl+"GetCurrentUserPhoto",httpOptions);
    }
     
    editprofile(user: User)
    {
      const httpOptions = {
        headers: new HttpHeaders({
          'Authorization': 'Bearer ' + localStorage.getItem('token')
        })
      };

      return this.http.post(this.profileurl+"EditCurrentUser",user,httpOptions);
        
    }

}
