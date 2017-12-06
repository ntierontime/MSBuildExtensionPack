import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent }  from './app.component';
import { BuildlogComponent } from './buildlog/buildlog.component';

@NgModule({
  imports:      [ BrowserModule ],
  declarations: [ AppComponent, BuildlogComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
