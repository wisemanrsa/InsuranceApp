import { Component, OnInit } from '@angular/core';
import { PremiumInterface } from 'src/app/models/premim.interface';
import { OldPremium } from 'src/app/models/old-premium';

@Component({
  selector: 'app-premium-manager',
  templateUrl: './premium-manager.component.html',
  styleUrls: ['./premium-manager.component.scss']
})
export class PremiumManagerComponent implements OnInit {
  finalPremium: PremiumInterface = {};
  oldPremiums: OldPremium[] = [];

  constructor() { }

  ngOnInit() {
  }

  handleFinalPremium(premium: PremiumInterface) {
    this.finalPremium = premium;
    this.finalPremium.total = premium.policyFee + premium.premium;
  }

  handleOldPremiums(premiums: OldPremium[]) {
    this.oldPremiums = premiums;
  }

}
