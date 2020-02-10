import React, { useState, useEffect } from 'react';
import StartButton from './StartButton';
import Summary from './Summary';
import GameBoard from './GameBoard';
import Typography from '@material-ui/core/Typography';
import PlayableResources from "../PlayableResources";

const Game = () => {
    const [selectedResource, setSelectedResource] = useState();
    const [gameStatus, setGameStatus] = useState("lobby");
    const [messageText, setMessageText] = useState();

    const randomElementFromArray = (array) => {
        return array[Math.floor(Math.random() * array.length)]
    }

    useEffect(() => {
        setSelectedResource(randomElementFromArray(PlayableResources));
    }, []);

    const startNewGame = () => {
        setGameStatus("active");
    }

    return (
        <div>
            <Typography align="center" variant="h3" component="p">
                Full Stack Battles
            </Typography>
            {
                (gameStatus === 'p1' ||
                    gameStatus === 'p2' ||
                    gameStatus === 'draw') &&
                <Summary gameStatus={gameStatus} />
            }
            {
                (gameStatus === 'active' ||
                    gameStatus === 'p1' ||
                    gameStatus === 'p2' ||
                    gameStatus === 'draw') &&
                <GameBoard
                    selectedResource={selectedResource}
                    gameStatus={gameStatus}
                    setGameStatus={setGameStatus}
                    setMessageText={setMessageText}
                />
            }
            {
                (gameStatus === 'lobby' ||
                    gameStatus === 'p1' ||
                    gameStatus === 'p2' ||
                    gameStatus === 'draw') &&
                <StartButton onClick={startNewGame} text={gameStatus === 'lobby' ? 'START' : 'RESTART'} />
            }
            {
                messageText &&
                <Typography align="center" variant="subtitle2" color="error" component="p">
                    {messageText}
                </Typography>
            }
        </div>
    )
}

export default Game;
