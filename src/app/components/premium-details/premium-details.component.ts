import { Component, OnInit, Input } from '@angular/core';
import { PremiumInterface } from 'src/app/models/premim.interface';

@Component({
  selector: 'app-premium-details',
  templateUrl: './premium-details.component.html',
  styleUrls: ['./premium-details.component.scss']
})
export class PremiumDetailsComponent implements OnInit {

  @Input()
  finalPremium: PremiumInterface = {};
  constructor() {

  }

  ngOnInit() {
  }

}
