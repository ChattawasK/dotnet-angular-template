import { ChangeDetectionStrategy, Component, OnInit } from '@angular/core';

@Component({
    selector: 'register',
    changeDetection: ChangeDetectionStrategy.OnPush,
    templateUrl: './register.component.html',
    styleUrls: ['register.component.scss'],
})
export class RegisterComponent implements OnInit {
    constructor() {}
    ngOnInit() {}
}
