import React from 'react';
import { makeStyles } from '@material-ui/core/styles';
import { Button } from '@material-ui/core';

const useStyles = makeStyles({
    buttonSection: {
        width: '100%',
        height: '30%',
        justifyContent: 'center',
        display: 'flex'
    },
    button: { 
        margin: 16
    },
});

const StartButton = (props) => {
    const classes = useStyles();

    return (
        <div className={classes.buttonSection}>
            <Button className={classes.button} color='primary' size='large' variant='contained' onClick={props.onClick}>
                {props.text}
            </Button>
        </div>
    );
}

export default StartButton;