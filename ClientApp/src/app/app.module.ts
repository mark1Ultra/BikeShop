import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {HttpClientModule} from '@angular/common/http';
import {FormsModule} from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import {Routes,RouterModule} from '@angular/router';

import { AppComponent } from './app.component';
import { NavComponent } from './nav/nav.component';
import { NotComponent } from './Not/Not.component';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AuthService } from './_services/auth.service';
import { ErrorInterceptorProvider } from './_services/error.interceptor';
import { AlertifyService } from './_services/alertify.service';
import { MessagesComponent } from './messages/messages.component';
import { appRoutes } from './routes';
import { AuthGuard } from './_guards/auth.guard';
import { BikeListComponent } from './bike-list/bike-list.component';
import { FooterComponent } from './footer/footer.component';
import { PostAddComponent } from './post-add/post-add.component';
import { ProfileComponent } from './profile/profile.component';
import { User_postComponent } from './user_post/user_post.component';




@NgModule({
   declarations: [
      AppComponent,
      NavComponent,
      NotComponent,
      HomeComponent,
      RegisterComponent,
      MessagesComponent,
      BikeListComponent,
      FooterComponent,
      PostAddComponent,
      ProfileComponent,
      User_postComponent
   ],
   imports: [
      BrowserModule,
      HttpClientModule,
      FormsModule,
      BsDropdownModule.forRoot(),
      RouterModule.forRoot(appRoutes)
   ],
   providers: [
      AuthService,
      ErrorInterceptorProvider,
      AlertifyService,
      AuthGuard
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
