import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { Router } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';

import { HeroesModule } from './heroes/heroes.module';
import { ComposeMessageComponent } from './compose-message.component';
import { LoginRoutingModule } from './login-routing.module';
import { LoginComponent } from './login.component';
import { PageNotFoundComponent } from './not-found.component';

import { DialogService } from './dialog.service';

import { BuildlogComponent } from './buildlog/buildlog.component';

//export const ROUTES: Routes = [
//  { path: '', component: BuildlogComponent }
//];

import { HttpClientModule } from '@angular/common/http';

import { AppComponent }  from './app.component';


@NgModule({
  imports: [
    BrowserModule,
    HttpClientModule,
    BrowserAnimationsModule,
    AppRoutingModule,
    FormsModule,
    HeroesModule,
    LoginRoutingModule], //RouterModule.forRoot(ROUTES), 
  declarations: [
    AppComponent,
    ComposeMessageComponent,
    LoginComponent,
    PageNotFoundComponent,
    BuildlogComponent],
  providers: [
    DialogService
  ],
  bootstrap:    [ AppComponent ]
})
export class AppModule {
  constructor(router: Router) {
    console.log('Routes: ', JSON.stringify(router.config, undefined, 2));
  }
}
