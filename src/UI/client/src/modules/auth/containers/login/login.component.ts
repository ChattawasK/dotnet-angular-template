import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';

@Component({
    selector: 'login',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './login.component.html',
    styleUrls: ['login.component.scss'],
})
export class LoginComponent implements OnInit {
    constructor() {}
    ngOnInit() {}
}
