import React from 'react';
import Typography from '@material-ui/core/Typography';

const Summary = (props) => {
    switch (props.gameStatus) {
        case 'p1':
            return <Typography align="center" variant="h4" component="p">
                Player 1 wins!
            </Typography>
        case 'p2':
            return <Typography align="center" variant="h4" component="p">
                Player 2 wins!
            </Typography>
        case 'draw':
            return <Typography align="center" variant="h4" component="p">
                Draw!
            </Typography>
        default:
            return null;
    }
}

export default Summary;