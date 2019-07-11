import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PremiumManagerComponent } from './components/premium-manager/premium-manager.component';
import { PremiumCalculatorComponent } from './components/premium-calculator/premium-calculator.component';
import { PremiumDetailsComponent } from './components/premium-details/premium-details.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    PremiumManagerComponent,
    PremiumCalculatorComponent,
    PremiumDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
