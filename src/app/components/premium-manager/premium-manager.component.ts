import { Component, OnInit } from '@angular/core';
import { PremiumInterface } from 'src/app/models/premim.interface';

@Component({
  selector: 'app-premium-manager',
  templateUrl: './premium-manager.component.html',
  styleUrls: ['./premium-manager.component.scss']
})
export class PremiumManagerComponent implements OnInit {
  finalPremium: PremiumInterface = {};

  constructor() { }

  ngOnInit() {
  }

  handleFinalPremium(premium: PremiumInterface) {
    this.finalPremium = premium;
    this.finalPremium.total = premium.policyFee + premium.premium;
  }

}
