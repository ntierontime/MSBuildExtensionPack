import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

// Import HttpClientModule from @angular/common/http
import { HttpClientModule } from '@angular/common/http';

import { AppComponent }  from './app.component';
import { BuildlogComponent } from './buildlog/buildlog.component';

@NgModule({
  imports: [BrowserModule, HttpClientModule ],
  declarations: [ AppComponent, BuildlogComponent ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
